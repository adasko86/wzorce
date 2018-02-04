using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Fasada
    {
        public void ObliczPierWieomianu(double a, double b, double c)
        {
            ObliczPierwWiel ob = new ObliczPierwWiel();
            double delta = b * b - 4.0 * a * c;
            if (delta > 0)
            {
                ob.DeltaDodatnia(a, b, c);
            }
            else if (delta == 0)
            {
                ob.DeltaRownaZero(a, b, c);
            }
            else
            {
                ob.DeltaUjemna(a, b, c);
            }
        }
    }
}
