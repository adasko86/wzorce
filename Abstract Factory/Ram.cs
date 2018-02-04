using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IRam
    {
        IRam dodajRam();
    }

    class DDR3 : IRam
    {
        String name = "DDR3";
        public IRam dodajRam()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DDR3();
        }
    }

    class DDR2 : IRam
    {
        String name = "DDR2";
        public IRam dodajRam()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DDR2();
        }
    }
}
