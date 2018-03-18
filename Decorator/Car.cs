using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        public abstract decimal CostCar();

        public abstract string TypeEngine();

        public abstract string ColorCar();
    }
}
