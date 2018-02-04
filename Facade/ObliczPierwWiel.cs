using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class ObliczPierwWiel
    {
        public void DeltaDodatnia(double a, double b, double c)
        {
            double delta = b * b - 4.0 * a * c;
            Console.WriteLine("Pierwszy pierwiastek: {0}", (-b - delta) / (2 * a));
            Console.WriteLine("Drugi pierwiastek: {0}", (-b + delta) / (2 * a));
        }

        public void DeltaRownaZero(double a, double b, double c)
        {
            Console.WriteLine("Pierwiastek: {0}", (-b) / (2 * a));
        }

        public void DeltaUjemna(double a, double b, double c)
        {
            Console.WriteLine("Brak pierwiastków wielomianu kwadratowego");
        }
    }
}
