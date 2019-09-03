using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var serial = new SerialPort())
            {
                var sim = new Sim800L(serial, "COM8");
                while (true)
                {
                    Console.WriteLine("A: answer\nH: hangup\nD: dial");
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.A:
                            sim.Answer();
                            break;
                        case ConsoleKey.H:
                            sim.Hangup();
                            break;
                        case ConsoleKey.D:
                            Console.WriteLine("Type number to dial.");
                            var number = Console.ReadLine();
                            sim.Dial(number);
                            break;
                    }
                }
            }

        }
    }
}
