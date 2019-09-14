using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsmComm.GsmCommunication;


namespace GSM_UI
{
    public partial class Form1 : Form
    {
        public GsmPhone GSM { get; set; }

        public bool Connected => GSM != null && GSM.IsConnected();

        public Form1()
        {
            InitializeComponent();
        }

        private void LogHandler(object sender, LoglineAddedEventArgs e)
        {
            dataReceivedRichTextBox.Invoke((MethodInvoker)delegate
            {
                dataReceivedRichTextBox.AppendText($"{e.Text}\n", Color.Blue);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portComboBox.Items.AddRange(SerialPort.GetPortNames());
            baudRateComboBox.SelectedIndex = 4;
            mainTabControl.Enabled = false;
            disconnectBtn.Enabled = false;
            getInfoButton.Enabled = false;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            ((IProtocol)GSM).ExecAndReceiveMultiple(cmdTextBox.Text.Trim());
        }

        private void CallBtn_Click(object sender, EventArgs e)
        {
            ((IProtocol)GSM).ExecAndReceiveMultiple($"ATD{dialTextBox.Text.Trim()};");
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            ((IProtocol)GSM).ExecAndReceiveMultiple("ATA");
        }

        private void HangupBtn_Click(object sender, EventArgs e)
        {
            ((IProtocol)GSM).ExecAndReceiveMultiple("ATH");
        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                connectionDeviceModelText.Text = GSM.RequestModel();
                connectionManufacturerText.Text = GSM.RequestManufacturer();
                connectionStatusText.Text = GSM.IsConnected() ? "OK" : "Disconnected";
            }
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

                GSM = new GsmPhone(portComboBox.SelectedText, int.Parse(baudRateComboBox.SelectedText), parsedTimeout);
                GSM.Open();
                mainTabControl.Enabled = true;
                disconnectBtn.Enabled = true;
                portComboBox.Enabled = true;
                baudRateComboBox.Enabled = true;
                getInfoButton.Enabled = true;
                GSM.LoglineAdded += LogHandler;
            }
        }

        private void FindPortsBtn_Click(object sender, EventArgs e)
        {
            portComboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                GSM.Close();
                mainTabControl.Enabled = false;
                disconnectBtn.Enabled = false;
                portComboBox.Enabled = false;
                baudRateComboBox.Enabled = false;
                getInfoButton.Enabled = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Connected) GSM.Close();
        }
    }
}
