// See https://aka.ms/new-console-template for more information

using Operators;

Console.WriteLine("Enter in a number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("Enter in another number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int divideMethod = OperatingClass.Divide(firstNum, secondNum);
int modulusMethod = OperatingClass.Modulus(firstNum, secondNum);


Console.WriteLine($"The sum of the numbers are: {OperatingClass.Add(firstNum, secondNum)}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");

Console.WriteLine($"The first number minus the second number is: {OperatingClass.Subtract(firstNum, secondNum)}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");

Console.WriteLine($"The first number times the second number is: {OperatingClass.Multiply(firstNum, secondNum)}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");

Console.WriteLine($"The first number divided by the second number is: {divideMethod} with a remainder of {modulusMethod}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Do you want to find the area of a circle with me? \n" +
                  "yes to continue|anything else to end the program");
string answer = Console.ReadLine();
if (answer == "yes")
{
    Console.WriteLine("Enter the radius of your circle:");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The area of the circle is... {OperatingClass.Area(radius)}");
}
else
{
    Console.WriteLine("I guess you dont get to do something cool ;(");
}
