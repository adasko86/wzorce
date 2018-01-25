using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class AK47 : AbstractGun
    {
        public AK47()
        {
            this.gunArmor = 100;
            this.gunFrame = 112;
            this.gunPower = 75;
            this.gunType = GunType.AK47;
        }

        public void setPrice(float price)
        {
            gunPrice = price;
        }
    }
}
