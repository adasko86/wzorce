using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Ferrari : Car
    {
        public override decimal CostCar()
        {
            return 70000;
        }

        public override string TypeEngine()
        {
            return "V-12";
        }

        public override string ColorCar()
        {
            return "Red";
        }
    }
}
