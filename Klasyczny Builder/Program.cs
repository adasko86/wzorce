using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new RaceCarBuilder();
            CarDirector carDirector = new CarDirector(carBuilder);
            carDirector.makeCar();

            Car car = carDirector.getCar();
            Console.WriteLine(car);

            carBuilder = new MaluchBuilder();
            carDirector = new CarDirector(carBuilder);
            carDirector.makeCar();

            car = carDirector.getCar();
            Console.WriteLine(car);
            Console.Read();
        }
    }
}
