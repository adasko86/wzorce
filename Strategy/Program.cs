using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax tax = new TaxPL();
            Console.WriteLine("Podatek w Polsce: " + tax.count(100)); 
            tax = new TaxEN();
            Console.WriteLine("Podatek w Anglii: " + tax.count(100)); 
            tax = new TaxDE();
            Console.WriteLine("Podatek w Niemczech: " + tax.count(100));
            Console.Read();
        }
    }
}
