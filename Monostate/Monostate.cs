using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    public class Monostate
    {
        private static int itsX = 0;
        public Monostate() { }
        public void setX(int x)
        {
            itsX = x;
        }
        public int getX()
        {
            return itsX;
        }

        public override string ToString()
        {
            return "Liczna wynosi : " + getX();
        }
    }
}
