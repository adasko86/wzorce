using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ClickSwitch cswitch = new ClickSwitch(new tv());
            cswitch.on();
            cswitch.off();

            cswitch = new ClickSwitch(new Radio());
            cswitch.on();
            cswitch.off();

            cswitch = new ClickSwitch(new Lamp());
            cswitch.on();
            cswitch.off();
            Console.Read();
        }
    }
}
