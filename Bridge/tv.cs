using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class tv : IDevice
    {
        public void on()
        {
            Console.WriteLine("Włączono telewizor!");
        }

        public void off()
        {
            Console.WriteLine("Wyłączono telewizor!");
        }
    }
}
