using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public class Car
    {
        private Tires tires;
        internal Tires Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        private Engine engine;
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public override string ToString()
        {
            return "Car " + engine.ToString() + " " + tires.ToString();
        }
    }
}
