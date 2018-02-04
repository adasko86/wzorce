using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IGrafika
    {
        IGrafika dodajGrafike();
    }

    class GrafikaDlaPC : IGrafika
    {
        String name = "GrafikaDlaPC";
        public IGrafika dodajGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaPC();
        }
    }

    class GrafikaDlaLaptopa : IGrafika
    {
        String name = "GrafikaDlaPC";
        public IGrafika dodajGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaPC();
        }
    }
}
