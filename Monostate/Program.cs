using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            Monostate m1 = new Monostate();
            Monostate m2 = new Monostate();

            m1.setX(9);

            Console.WriteLine("M1: " + m1.ToString());
            Console.WriteLine("M2: " + m1.ToString());

            m1.setX(22);

            Console.WriteLine("M1: " + m1.ToString());
            Console.WriteLine("M2: " + m1.ToString());

            Console.Read();
        }
    }
}
