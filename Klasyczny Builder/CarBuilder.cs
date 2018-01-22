using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasyczny_Builder
{
    public interface CarBuilder
    {

        void buildTires();

        void buildEngine();

        Car getCar();

    }
}
