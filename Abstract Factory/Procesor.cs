using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IProcesor
    {
        IProcesor dodajProcesor();
    }

    class ProcesorDlaPC : IProcesor
    {
        String name = "ProcesorDlaPC";
        public IProcesor dodajProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaPC();
        }
    }

    class ProcesorDlaLaptopa : IProcesor
    {
        String name = "ProcesorDlaLaptopa";
        public IProcesor dodajProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaLaptopa();
        }
    }
}
