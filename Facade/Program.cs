using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fasada ob = new Fasada();///<-to nasa fasada
            ob.ObliczPierWieomianu(2, -6, 4);
            Console.Read();
        }
    }
}
