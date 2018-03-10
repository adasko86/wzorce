using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TaxPL : Tax
    {
        public decimal count(decimal value)
        {
            return value * 0.23m;
        }
    }
}
