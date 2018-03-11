using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Class_Description
    {
        string description;
        public Class_Description(string _description)
        {
            description = _description;
        }

        public string getDescription()
        { 
            return description;
        }
    }
}
