using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the pin");
            int pin = int.Parse(Console.ReadLine());

            CartBank cartbank = new CartBank();
            cartbank.getPIN(pin);

            if (cartbank.IfPinIsValid)
            {
                bool enterCorrectValue = false;
                while(!enterCorrectValue)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Take out the money");
                    Console.WriteLine("2. Pay the money");
                    int enteredValue = int.Parse(Console.ReadLine());
                    if(enteredValue == 1)
                    {
                        Console.WriteLine("How much money do you want to pay?");
                        double money = double.Parse(Console.ReadLine());
                        if (cartbank.CheckStateAccount() < money)
                            Console.WriteLine("You didn't have enough money in your account");
                        cartbank.PayOutMoneyFromAccount(money);
                        Console.WriteLine("You have: " + cartbank.CheckStateAccount() + " USD left in your account");
                        Console.WriteLine("By By!!");
                        enterCorrectValue = true;
                    }
                    else if(enteredValue == 2)
                    {
                        Console.WriteLine("How much money do you want to pay?");
                        double money = double.Parse(Console.ReadLine());
                        cartbank.PayOutMoneyFromAccount(-money);
                        Console.WriteLine("You have: " + cartbank.CheckStateAccount() + " USD left in your account");
                        Console.WriteLine("By By!!");
                        enterCorrectValue = true;
                    }
                    else
                    {
                        Console.WriteLine("Bad number. Please try again");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect pin entered, try again");
            }

            Console.ReadKey();
        }
    }
}
