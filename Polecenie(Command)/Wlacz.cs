using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command_
{
    public class Wlacz : Command
    {
        public void run()
        {
            Console.WriteLine("Włączanie maszyny");
        }
    }
}
