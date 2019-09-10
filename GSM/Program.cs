using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PduBitPacker;

namespace GSM
{
    class Program
    {
        static void Main(string[] args)
        {

            //var sim = new Sim800L("COM8");

            //Console.WriteLine(sim.Command("AT+CMGF=1"));
            //Console.WriteLine(sim.Command("AT+CSCS=\"GSM\""));
            //Console.WriteLine(sim.Command("AT+CMGS=\"3853093066\""));
            //Console.WriteLine(sim.Command("hello" + (char)26));



            //Console.WriteLine(sim.Command("AT+CMGF=0"));
            //Console.WriteLine(sim.Command("AT+CMGS=47"));
            //Console.WriteLine(sim.Command("0001000A818335900366410027CC32FD3407B5CB653A284C07DDE06D50980EA2A3CB20BA3C9C7683E6F4303DFD76BB00" + (char)26));


            //Console.WriteLine(sim.Command("AT+CMGF=0"));
            //Console.WriteLine(sim.Command("AT+CMGS=47"));
            //Console.WriteLine(sim.Command("0001000A818335900366410027CC32FD3407B5CB653A284C07E1E06D50980EA2A3CB20BA3C9C7683E6F4303DFD76BB00" + (char)26));

            //SendPDUMessage("8016912942", "Hello, how are you?", null);
            while (true)
            {
                Console.WriteLine(ConvertMessageToEncodedHex(Console.ReadLine()));
            }

            //while (true)
            //{
            //    var cmd = Console.ReadLine();
            //    Console.WriteLine(sim.Command(cmd));
            //}

        }
        static void SendPDUMessage(string phoneNumber, string message, Sim800L sim)
        {
            string messageType = "0001"; // SMS-SUBMIT
            

            Console.WriteLine($"{messageType}00{phoneNumber.Length:X}81{ConvertNumber(phoneNumber)}410027{message.Length:X}{ConvertMessageToEncodedHex(message)}{(char)26}");

            //Console.WriteLine(sim.Command("AT+CMGF=0"));
            //Console.WriteLine(sim.Command($"AT+CMGS={bytes.Length}"));
            //Console.WriteLine(sim.Command($"0001000A81{ConvertNumber(phoneNumber)}410027{bytes.Length:X}{PduBitPacker.ConvertBytesToHex(bytes)}{(char)26}"));
        }

        static string ConvertNumber(string number)
        {
            if (number.Length != 10) throw new Exception("Phone number must be 10 digits");
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < number.Length; i += 2)
            {
                sb.Append(number[i]).Append(number[i - 1]);
            }

            return sb.ToString();
        }

        static string ConvertMessageToEncodedHex(string message)
        {
            return PduBitPacker.ConvertBytesToHex(PduBitPacker.PackBytes(Encoding.ASCII.GetBytes(message)));
        }
    }
}
