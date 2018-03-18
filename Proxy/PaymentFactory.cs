using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    abstract class PaymentFactory
    {
        public abstract IPayment Bank();
    }
}
