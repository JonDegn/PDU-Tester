using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Sim800L
    {
        private SerialPort Serial { get; }

        public Sim800L(SerialPort serial, string port)
        {
            Serial = serial;
            Serial.PortName = port;
            Serial.BaudRate = 115200; // todo: double check baud
            Serial.Parity = Parity.None;
            Serial.StopBits = StopBits.One;
            Serial.DataBits = 8;
            Serial.Handshake = Handshake.None;

            //Serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            Serial.Open();

            
        }



        public void Answer()
        {
            Command("ATA");
        }

        public void Dial(string number)
        {
            Command($"ATD{number};");
        }

        public void Hangup()
        {
            Command("ATH");
        }

        public void Redial()
        {
            Command("ATDL");
        }

        public void SetAutoAnswer(int rings)
        {
            Command($"ATS0={rings}");
        }

        private void Ring()
        {
            Console.Beep();
        }

        //private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    SerialPort sp = (SerialPort)sender;
        //    string indata = sp.ReadExisting();

        //    Console.WriteLine("Data Received:");
        //    Console.Write(indata);

        //    if (indata == "RING")
        //    {
        //        Ring();
        //    }
        //    else if (indata.StartsWith("+CMTI"))
        //    {
        //        //incoming message
        //    }
        //}

        public void Command(string cmd)
        {
            Serial.Write($"{cmd}\n");
        }

    }
}
