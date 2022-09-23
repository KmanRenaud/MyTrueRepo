using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank_Account
    {


        public static double balance = 0;

        public static double Deposit(double depMoney)
        {
            return balance += depMoney;
        }

        public static double Withdrawal(double witMoney)
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


        public static void GetBalance()
        {
            Console.WriteLine(balance);
        }






    }
}
