using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public class Tires
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return "Tires (" + name + ", " + type + ")";
        }
    }
}
