using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Famas : AbstractGun
    {
        public Famas()
        {
            this.gunArmor = 100;
            this.gunFrame = 132;
            this.gunPower = 65;
            this.gunType = GunType.Famas;
        }

        public void setPrice(float price)
        {
            gunPrice = price;
        }
    }
}
