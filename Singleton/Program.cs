using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s = new Singleton(); // błąd nie można utworzyć obiektu (konstruktor jest prywatny). To działa :D
            Singleton s1 = Singleton.getSingleton();
            Singleton s2 = Singleton.getSingleton();

            s1.name = "Janek";
            s2.name = "Bartek";

            Console.WriteLine(s1.name);
            Console.WriteLine(s2.name);

            //Singleton_prosty s = new Singleton_prosty(); // błąd nie można utworzyć obiektu (konstruktor jest prywatny). To działa :D
            Singleton_prosty sp1 = Singleton_prosty.instance;
            Singleton_prosty sp2 = Singleton_prosty.instance;

            sp1.name = "Mietek";
            sp2.name = "Wacek";

            Console.WriteLine(sp1.name);
            Console.WriteLine(sp2.name);
            Console.Read();
        }
    }
}
