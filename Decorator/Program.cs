using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Mercedes();

            mercedes = new RadioDecorator(mercedes);

            Console.WriteLine("The cost of a car with radio: " + mercedes.CostCar());

            Console.ReadKey();
        }
    }
}
