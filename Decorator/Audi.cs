using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Audi : Car
    {
        public override decimal CostCar()
        {
            return 50000;
        } 

        public override string TypeEngine()
        {
            return "2,0 TDI";
        }

        public override string ColorCar()
        {
            return "Black";
        }
    }
}
