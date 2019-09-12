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

            var comm = new GsmCommMain("COM7", 115200);
            comm.Open();
            try
            {
                var pdu = new SmsSubmitPdu("How does this look?", "3853093066");
                //pdu.ProtocolID = 64;
                //pdu.DataCodingScheme = 64;
                
                comm.SendMessage(pdu);
                Thread.Sleep(1000);
            }
            finally
            {
                comm.Close();
            }
            Console.ReadKey();


        }





        enum ProtocolIdentifier
        {
            ShortMessage = 0,
            ShortMessageType0 = 64,
            ReplaceShortMessageType1 = 65,
            ReplaceShortMessageType2 = 66,
            ReplaceShortMessageType3 = 67,
            ReplaceShortMessageType4 = 68,
            ReplaceShortMessageType5 = 69,
            ReplaceShortMessageType6 = 70,
            ReplaceShortMessageType7 = 71
        }
    }
}
