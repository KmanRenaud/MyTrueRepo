// See https://aka.ms/new-console-template for more information


Random rnd = new Random();
int randomNum = rnd.Next(1, 10);

while (true)
{
    try
    {

        Console.Write("Guess a whole number from 1 to 10... ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        if (userNum == randomNum)
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Try again...");
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid Input...");
    }
}
Console.WriteLine("Good job! To continue click enter...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Choose a school subject please: ");
Console.WriteLine("Math, Science, Programming, History, or English...");
string userSubject = Console.ReadLine();
Console.Clear();

switch(userSubject)
{
    case "Math":
        Console.WriteLine("Math is awesome!");
        break;
    case "Science":
        Console.WriteLine("Science is awesome!");
        break;
    case "Programming":
        Console.WriteLine("Programming is awesome!");
        break;
    case "History":
        Console.WriteLine("History is awesome!");
        break;
    default:
        Console.WriteLine("That not a subject!");
            break;

}

