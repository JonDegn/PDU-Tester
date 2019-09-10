using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSM
{
    public class Sim800L : IDisposable
    {

        private SerialPort Serial { get; }
        private Queue<string> Buffer { get; } = new Queue<string>();
 
        public EventHandler OnRing { get; set; }
        public EventHandler OnClip { get; set; }
        public EventHandler OnClcc { get; set; }
        public EventHandler<string> DataReceived { get; set; }

        public Sim800L(string port)
        {
            Serial = new SerialPort();
            Serial.PortName = port;
            Serial.BaudRate = 115200; // todo: double check baud
            Serial.Parity = Parity.None;
            Serial.StopBits = StopBits.One;
            Serial.DataBits = 8;
            Serial.Handshake = Handshake.None;

            Serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            
            Serial.Open();
        }

        

        // For testing
        protected Sim800L(SerialPort serial)
        {
            Serial = serial;
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

        private void Ring(EventArgs e)
        {
            OnRing?.Invoke(this, e);
        }

        private void Clip(EventArgs e)
        {
            OnClip?.Invoke(this, e);
        }

        private void Clcc(EventArgs e)
        {
            OnClcc?.Invoke(this, e);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            
            while (Serial.BytesToRead > 0)
            {
                var rawData = sp.ReadLine();
                DataReceived?.Invoke(this, rawData);
                if (rawData.StartsWith("RING"))
                {
                    Ring(EventArgs.Empty);
                }
                else if (rawData.StartsWith("+CLIP"))
                {
                    //+CLIP: "+13853093066",145,"",0,"",0

                }
                else if (rawData.StartsWith("+CLCC"))
                {
                    //+CLCC: 1,1,4,0,0,"+13853093066",145,""
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(rawData)) Buffer.Enqueue(rawData);
                }
            }
        }

        public string Command(string cmd, int waitFor = 500)
        {
            Serial.Write($"{cmd}\n");
            return GetResult(waitFor);
        }

        private string GetResult(int waitFor)
        {
            var watch = Stopwatch.StartNew();
            string result = "";
            //Thread.Sleep(500);
            while (Buffer.Count == 0 && watch.ElapsedMilliseconds < waitFor)
            {
                Thread.Sleep(50);
            }
            while (Buffer.Count != 0)
            {
                var val = Buffer.Dequeue();
                //if (val.StartsWith("OK")) break;
                result += val + "\n";
            }
            return result.Trim();
        }

        public void Dispose()
        {
            Serial.Close();
        }
    }
}
