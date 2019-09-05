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
using GSM;

namespace GSM_UI
{
    public partial class Form1 : Form
    {
        public Sim800L GSM { get; }

        public Form1()
        {
            InitializeComponent();
            GSM = new Sim800L("COM9");
            GSM.Command("ATE0");
        }

        private void GetInfo()
        {
            GSM.Command("AT+CGMM");
            GSM.Command("AT+CGMI");
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            GSM.Command(cmdTextBox.Text.Trim());
        }

        private void CallBtn_Click(object sender, EventArgs e)
        {
            dataReceivedRichTextBox.AppendText($"Dialing {dialTextBox.Text}...\n\n");
            GSM.Dial(dialTextBox.Text);
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            GSM.Answer();
        }

        private void HangupBtn_Click(object sender, EventArgs e)
        {
            GSM.Hangup();
        }

        //private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{

        //    SerialPort sp = (SerialPort)sender;

        //    while (sp.BytesToRead > 0)
        //    {
        //        string rawData = sp.ReadLine();

        //        dataReceivedRichTextBox.Invoke((MethodInvoker)delegate
        //        {
        //            dataReceivedRichTextBox.AppendText(rawData, Color.Blue);
        //        });
        //        var parameters = rawData.Split(',');

        //        if (rawData.StartsWith("+CLIP"))
        //        {
        //            phoneNumberTextBox.Invoke((MethodInvoker)delegate
        //            {
        //                phoneNumberTextBox.Text = parameters[0].Substring(7).Trim('\"');
        //            });
        //        }

        //        if (rawData.StartsWith("AT+CGMM"))
        //        {
        //            rawData = sp.ReadLine();
        //            dataReceivedRichTextBox.Invoke((MethodInvoker)delegate
        //            {
        //                dataReceivedRichTextBox.AppendText(rawData, Color.Blue);
        //            });

        //            phoneNumberTextBox.Invoke((MethodInvoker)delegate
        //            {
        //                connectionDeviceModelText.Text = rawData;
        //            });
        //        }

        //        if (rawData.StartsWith("AT+CGMI"))
        //        {
        //            rawData = sp.ReadLine();
        //            dataReceivedRichTextBox.Invoke((MethodInvoker)delegate
        //            {
        //                dataReceivedRichTextBox.AppendText(rawData, Color.Blue);
        //            });

        //            phoneNumberTextBox.Invoke((MethodInvoker)delegate
        //            {
        //                connectionManufacturerText.Text = rawData;
        //            });
        //        }
        //    }
        //}

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            connectionManufacturerText.Text = GSM.Command("AT+CGMM");
            GSM.Command("AT+CGMI");
        }
    }
}
