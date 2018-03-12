using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ClickSwitch : Switch
    {
        public ClickSwitch(IDevice idevice):base(idevice)
        {

        }

        public override void on()
        {
            base.device.on();
        }

        public override void off()
        {
            base.device.off();
        }
    }
}
