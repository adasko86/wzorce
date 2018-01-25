using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public interface I_AbstractGun
    {
        GunType getType();
        int getGunPower();
        float getGunCost();
        int getGunArmor();
        int getGunFrame();
    }
}
