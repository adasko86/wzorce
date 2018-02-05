using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface ProductAbstract
    {
        String getProductName();
        void showMe();
        void addChild(ProductAbstract p);
        void removeChild(ProductAbstract p);
    }
}
