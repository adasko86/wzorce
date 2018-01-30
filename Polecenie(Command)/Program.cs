using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command_
{
    class Program
    {
        public enum PrintCommand
        {
            wlacz,
            drukuj,
            wylacz
        }

        static void Main(string[] args)
        {
            Command commandWlacz = new Wlacz();
            commandWlacz.run();
            Command commandDrukuj = new Drukuj();
            commandDrukuj.run();
            Command commandWylacz = new Wylacz();
            commandWylacz.run();

            Console.Read();
        }
    }
}
