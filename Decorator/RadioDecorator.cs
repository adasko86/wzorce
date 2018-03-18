using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class RadioDecorator : CarDecorator
    {
        public RadioDecorator(Car car)
            : base(car) { }

        public override string ColorCar()
        {
            return base.ColorCar();
        }

        public override decimal CostCar()
        {
            return base.CostCar() + 1232.32m;
        }

        public override string TypeEngine()
        {
            return base.TypeEngine();
        }
    }
}
