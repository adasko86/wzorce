using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Mercedes : Car
    {
        public override decimal CostCar()
        {
            return 120000;
        }

        public override string TypeEngine()
        {
            return "V-8";
        }

        public override string ColorCar()
        {
            return "Yellow";
        }
    }
}
