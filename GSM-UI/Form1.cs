using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;


namespace GSM_UI
{
    public partial class Form1 : Form
    {
        private GsmPhone GSM { get; set; }
        private bool Connected => GSM != null && GSM.IsConnected();
        private Queue<string> LogQueue { get; }

        public Form1()
        {
            InitializeComponent();
            LogQueue = new Queue<string>();
            dcsComboBox.DataSource = Enum.GetValues(typeof(DataCodingScheme));
            pidComboBox.DataSource = Enum.GetValues(typeof(ProtocolIdentifier));
        }

        private void LogHandler(object sender, LoglineAddedEventArgs e)
        {
            dataReceivedRichTextBox.Invoke((MethodInvoker)delegate
            {
                LogQueue.Enqueue(e.Text);
                dataReceivedRichTextBox.AppendText($"{e.Text}\n", Color.Blue);
            });
        }

        private void PopulatePortDropdown()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => new { name = n, desc = n + " - " + ports.FirstOrDefault(s => s.Contains(n)) }).ToList();

                portComboBox.Items.Clear();
                portComboBox.Items.AddRange(portList.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePortDropdown();
            if (portComboBox.Items.Count > 0) portComboBox.SelectedIndex = 0;
            baudRateComboBox.SelectedIndex = 4;
            dcsComboBox.SelectionChangeCommitted += (s, ea) => UpdatePduString();
            pidComboBox.SelectionChangeCommitted += (s, ea) => UpdatePduString();
            requestStatusReportCheckBox.CheckedChanged += (s, ea) => UpdatePduString();
            smsMessageTextBox.TextChanged += (s, ea) => UpdatePduString();
            smsMessagePhoneNumberTextBox.TextChanged += (s, ea) => UpdatePduString();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                GSM.GetProtocol().ExecAndReceiveMultiple(cmdTextBox.Text.Trim());
                GSM.ReleaseProtocol();
            });

        }

        private void GetInfo()
        {

            if (Connected)
            {
                connectionDeviceModelText.Invoke((MethodInvoker)delegate
                {
                    connectionDeviceModelText.Text = GSM.RequestModel();
                    connectionManufacturerText.Text = GSM.RequestManufacturer();
                    connectionStatusText.Text = GSM.IsConnected() ? "OK" : "Disconnected";
                    batteryLevel.Text = GSM.GetBatteryCharge().BatteryChargeLevel.ToString();
                });
            }
            else
            {
                connectionDeviceModelText.Invoke((MethodInvoker)delegate
                {
                    connectionStatusText.Text = "Disconnected";
                });
            }
        }

        private void PhoneDisconnectedHandler(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Connect()
        {
            connectBtn.Invoke((MethodInvoker)delegate
            {
                connectBtn.Text = "Disconnect";
            });

        }

        private void Disconnect()
        {
            connectBtn.Invoke((MethodInvoker)delegate
            {
                connectBtn.Text = "Connect";
            });
            connectionStatusText.Invoke((MethodInvoker)delegate
            {
                connectionStatusText.Text = "Disconnected";
            });
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                if (!int.TryParse(timeoutTextBox.Text, out var parsedTimeout))
                {
                    MessageBox.Show("Timeout must be a number.");
                    return;
                }

                dynamic port = portComboBox.SelectedItem;
                GSM = new GsmPhone((string)port.name, int.Parse((string)baudRateComboBox.SelectedItem), parsedTimeout);
                GSM.Open();
                GSM.LoglineAdded += LogHandler;
                GSM.PhoneDisconnected += PhoneDisconnectedHandler;
                Connect();
                Task.Run(GetInfo);
            }
            else
            {
                GSM.Close();
                Disconnect();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LogQueue.Count > 0) Task.Run(() => File.WriteAllLines($"{DateTime.Now:yyyyMMddHHmmss}_gsm.log", LogQueue));
            if (Connected) GSM.Close();
        }

        private void UpdatePduString()
        {
            var pdu = new SmsSubmitPdu(smsMessageTextBox.Text, smsMessagePhoneNumberTextBox.Text);
            var pid = (int)Enum.Parse(typeof(ProtocolIdentifier), pidComboBox.SelectedValue.ToString());
            var dcs = (int)Enum.Parse(typeof(DataCodingScheme), dcsComboBox.SelectedValue.ToString());
            pdu.ProtocolID = (byte)pid;
            pdu.DataCodingScheme = (byte)dcs;
            pdu.RequestStatusReport = requestStatusReportCheckBox.Checked;
            pduLengthLabel.Text = pdu.ActualLength.ToString();
            pduTextBox.Text = pdu.ToString();
        }

        private void SmsMessageSendSmsButton_Click(object sender, EventArgs e)
        {
            var pdu = new SmsSubmitPdu(smsMessageTextBox.Text, smsMessagePhoneNumberTextBox.Text);
            Enum.TryParse(pidComboBox.SelectedValue.ToString(), out ProtocolIdentifier pid);
            Enum.TryParse(dcsComboBox.SelectedValue.ToString(), out DataCodingScheme dcs);
            pdu.ProtocolID = (byte)pid;
            pdu.DataCodingScheme = (byte)dcs;
            pdu.RequestStatusReport = requestStatusReportCheckBox.Checked;
            try
            {
                GSM.SendMessage(pdu.ToString(), pdu.ActualLength);
            }
            catch (Exception ex)
            {
                dataReceivedRichTextBox.AppendText(ex.Message+"\n", Color.Red);
            }
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            dataReceivedRichTextBox.Text = "";
        }

        private void PortLabel_Click(object sender, EventArgs e)
        {
            PopulatePortDropdown();
            if (portComboBox.Items.Count > 0) portComboBox.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var messages = GSM.ListMessages(PhoneMessageStatus.All);
            dataReceivedRichTextBox.AppendText($"Messages:{messages.Length}\n");

            var inbox = new List<InboxMessage>();
            foreach (var msg in messages)
            {
                var sms = IncomingSmsPdu.Decode(msg.Data, true);
                inbox.Add(new InboxMessage
                {
                    Index = msg.Index,
                    Status = msg.Status == 0 ? "Unread" : "Read",
                    From = ((SmsDeliverPdu)sms).OriginatingAddress,
                    Date = sms.GetTimestamp().ToString(),
                    Message = sms.UserDataText
                });
            }
            smsInboxGrid.DataSource = inbox;
        }

        class InboxMessage
        {
            public int Index { get; set; }
            public string Status { get; set; }
            public string From { get; set; }
            public string Date { get; set; }
            public string Message { get; set; }
        }

    }
}
