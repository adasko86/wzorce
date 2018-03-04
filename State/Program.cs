using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            builder.quickExampleCarriage();
            Carriage carriage = builder.build();
            CarriageState state = new CarriageAvailable();
            carriage.setState(state);
            state.reportPosition(carriage);
            state = new CarriageDamaged();
            state.reportPosition(carriage);
            state = new CarriageUnavailable();
            state.reportPosition(carriage);
            Console.Read();
        }
    }
}
