using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public interface I_GunCreator
    {
        I_AbstractGun create(GunType gunType);
    }
}
