using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using PduBitPacker;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;

namespace GSM
{
    class Program
    {
        static void Main(string[] args)
        {

            var comm = new GsmPhone("COM11", 115200, 500);
            comm.Open();
            try
            {
                var pdu = new SmsSubmitPdu("How does this look?", "3853093066");
                //pdu.ProtocolID = 64;
                //pdu.DataCodingScheme = 64;

                comm.SendMessage(pdu.ToString(), pdu.ActualLength);
                //Console.WriteLine(comm.IsConnected());
                //Thread.Sleep(1000);
                //Console.WriteLine(comm.RequestManufacturer());
                //Thread.Sleep(1000);
                //Console.WriteLine(comm.RequestModel());
                Thread.Sleep(1000);
            }
            finally
            {
                comm.Close();
            }
            Console.ReadKey();


        }






    }
}
