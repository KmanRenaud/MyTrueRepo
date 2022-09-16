using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void ThousandToNeg()
        {
            for (int i = -1000; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ThreeToNineNineNine()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void CheckSame()
        {
            Console.WriteLine("Enter the first number... ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number... ");
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum != secondNum)
            {
                Console.WriteLine("The numbers are different");
            }
            else
            {
                Console.WriteLine("The numbers are the same");
            }
        }
        public static void CheckEven()
        {
            Console.WriteLine("Enter a number... ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        public static void CheckPositive()
        {
            Console.WriteLine("Enter a number... ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }
        public static void CanVote()
        {
            Console.WriteLine("Enter your age... ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You cant vote...");
            }
        }
        public static void TenRange()
        {
            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());
            if (number > -11 && number < 11)
            {
                Console.WriteLine("The number is less than ten and greater than negative 10");
            }
            else
            {
                Console.WriteLine("This number is either greater than ten or less than negative ten");
            }
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number...");
            int num = int.Parse(Console.ReadLine());
            List<int> table = new List<int>();
            for (int i = 1; i < 13; i++)
            {

                i++;
                table.Add(i);
            }
            Console.WriteLine("The multiplicaton table for that number is: ")
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{table[i] * num}, ");
            }
        }
    }
}
