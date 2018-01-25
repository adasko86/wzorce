using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Rewolwer : AbstractGun
    {
        public Rewolwer()
        {
            this.gunArmor = 100;
            this.gunFrame = 16;
            this.gunPower = 100;
            this.gunType = GunType.Rewolwer;
        }

        public void setPrice(float price)
        {
            gunPrice = price;
        }
    }
}
