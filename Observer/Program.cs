using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Kobieta ob1 = new Kobieta("Aga");
            Mezczyzna ob2 = new Mezczyzna("Mateusz");
            Mezczyzna ob3 = new Mezczyzna("Lukasz");
            //========================
            ob1.addObservator(ob2);
            ob1.addObservator(ob3);
            ob1.changeTrousersToSkirt();
            //========================
            ob2.addObservator(ob1);
            ob2.changeBlouseToShirt();
            Console.Read();
        }
    }
}
