using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class BankAccount : IPayment
    {
        private double StateMyAccount = 10000;
        public double CheckStateAccount()
        {
            return StateMyAccount;
        }

        public void PayOutMoneyFromAccount(double AmountPayedOutMoney)
        {
            StateMyAccount = StateMyAccount - AmountPayedOutMoney;
        }
    }
}
