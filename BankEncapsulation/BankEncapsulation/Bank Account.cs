using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank_Account
    {


        public double balance = 0;

        public double Deposit(double depMoney)
        {
            return balance += depMoney;
        }

        public double Withdrawal(double witMoney)
        {
            if ((balance - witMoney) < 0)
            {
                return balance;
            }
            else
            {
                return balance -= witMoney;
            }

        }


        public void GetBalance()
        {
            Console.WriteLine(balance);
        }






    }
}
