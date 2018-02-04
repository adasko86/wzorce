using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IChlodzenie
    {
        IChlodzenie dodajChlodzenie();
    }

    class ChlodzenieDlaLaptopa : IChlodzenie
    {
        String name = "ChlodzenieDlaLaptopa";
        public IChlodzenie dodajChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaLaptopa();
        }
    }
}
