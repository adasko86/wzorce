using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public class RaceCarBuilder : CarBuilder
    {
        private Car car;
        public RaceCarBuilder()
        {
            car = new Car();
        }

        public void buildTires()
        {
            Tires tires = new Tires();
            tires.Name = "Kormoran";
            tires.Type = "Zimowe";
            car.Tires = tires;
        }

        public void buildEngine()
        {
            Engine engine = new Engine();
            engine.Type = "v12";
            car.Engine = engine;
        }

        public Car getCar()
        {
            return car;
        }
    }
}
