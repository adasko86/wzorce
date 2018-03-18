using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CartBank : IPayment
    {
        IPayment BankAccount;
        private int PIN;
        public bool IfPinIsValid;

        public void getPIN(int pin)
        {
            PIN = pin;
            CheckPinIsValid();
        }

        private void CheckPinIsValid()
        {
            if (PIN == 1234)
            {
                OpenAccessToAccount();
                IfPinIsValid = true;
            }
            else
            {
                IfPinIsValid = false;
            }
        }

        private void OpenAccessToAccount()
        {
            PaymentFactory paymentfactory = new BankAccountFactory();

            BankAccount = paymentfactory.Bank();
        }

        public double CheckStateAccount()
        {
            return BankAccount.CheckStateAccount();
        }

        public void PayOutMoneyFromAccount(double AmountPayedOutMoney)
        {
            BankAccount.PayOutMoneyFromAccount(AmountPayedOutMoney);
        }
    }
}
