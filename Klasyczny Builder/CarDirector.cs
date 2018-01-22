using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public class CarDirector
    {
        private CarBuilder carBuilder;

        public CarDirector(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public void makeCar()
        {
            carBuilder.buildEngine();
            carBuilder.buildTires();
        }

        public Car getCar()
        {
            return this.carBuilder.getCar();
        }
    }
}
