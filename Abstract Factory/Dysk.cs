using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IDysk
    {
        IDysk dodajDysk();
    }

    class DyskDlaPC : IDysk
    {
        String name = "DyskDlaPC";
        public IDysk dodajDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaPC();
        }
    }

    class DyskDlaLaptopa : IDysk
    {
        String name = "DyskDlaLaptopa";
        public IDysk dodajDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaLaptopa();
        }
    }
}
