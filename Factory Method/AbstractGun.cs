using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class AbstractGun : I_AbstractGun
    {
        protected GunType gunType;
        protected int gunPower;
        protected float gunPrice;
        protected int gunArmor;
        protected int gunFrame;

        public GunType getType()
        {
            return gunType;
        }

        public int getGunPower()
        {
            return gunPower;
        }

        public float getGunCost()
        {
            return gunPrice;
        }

        public int getGunArmor()
        {
            return gunArmor;
        }

        public int getGunFrame()
        {
            return gunFrame;
        }

        public override string ToString()
        {
            return "Type: " + getType() + "\nPower: " + getGunPower() +"\nCost: " + getGunCost() +"\nArmor: " + getGunArmor() +"\nFrame: " + getGunFrame();
        }
    }
}
