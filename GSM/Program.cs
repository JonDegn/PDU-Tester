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

            var sim = new Sim800L("COM8");
            while (true)
            {
                var cmd = Console.ReadLine();
                Console.WriteLine(sim.Command(cmd));
            }

        }
    }
}
