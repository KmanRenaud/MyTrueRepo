// See https://aka.ms/new-console-template for more information



using RockPaperSciccors;

Console.WriteLine("Enter anything to play a game of rock paper scissors!");
Console.ReadLine();
Console.Clear();

while (true)
{
    if (RPSMethods.leaveProgram == true)
    {
        break;
    }
    RPSMethods.ChooseMode();
    RPSMethods.BestOfThree();
    RPSMethods.EndlessMode();
}


//Click enter to play rock paper sciccors
//Mode
//1. Best out of three
//2. Unlimited
//3. Quit
//Difficulty
//When done playing go back to top
