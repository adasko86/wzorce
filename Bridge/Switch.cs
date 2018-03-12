using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Switch
    {
        protected IDevice device = null;
        public Switch(IDevice idevice)
        {
            device = idevice;
        }

        public abstract void on();
        public abstract void off();
    }
}
