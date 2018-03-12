using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Radio : IDevice
    {
        public void on()
        {
            Console.WriteLine("Włączono radio!");
        }

        public void off()
        {
            Console.WriteLine("Wyłączono radio!");
        }
    }
}
