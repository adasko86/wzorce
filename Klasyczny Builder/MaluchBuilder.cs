using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public class MaluchBuilder : CarBuilder
    {
        private Car car = null;

        public MaluchBuilder()
        {
            car = new Car();
        }

        public void buildTires()
        {
            Tires tires = new Tires();
            tires.Name = "Dębica";
            tires.Type = "Zimowe";
            car.Tires = tires;
        }

        public void buildEngine()
        {
            Engine engine = new Engine();
            engine.Type = "v1";
            car.Engine = engine;
        }

        public Car getCar()
        {
            return car;
        }
    }
}
