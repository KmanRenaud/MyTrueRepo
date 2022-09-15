using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciccors
{
    public static class RPSMethods
    {
        public static bool endless = false;
        public static bool bestOutOfThree = false;
        public static bool leaveProgram = false;
        public static void ChooseMode()
        {

            while (true)
            {
                Console.WriteLine("###################");
                Console.WriteLine("Choose your mode...");
                Console.WriteLine("###################");
                Console.WriteLine("1. Endless");
                Console.WriteLine("2. First to three");
                Console.WriteLine("3. Quit");
                Console.WriteLine("###################");
                endless = false;
                bestOutOfThree = false;
                if (int.TryParse(Console.ReadLine(), out int modeInput))
                {


                    if (modeInput == 1)
                    {
                        endless = true;
                        Console.Clear();
                        break;
                    }
                    else if (modeInput == 2)
                    {
                        bestOutOfThree = true;
                        Console.Clear();
                        break;
                    }
                    else if (modeInput == 3)
                    {
                        Console.WriteLine("Bye, I hope you had fun!!! To leave, please click enter.");
                        Console.ReadLine();
                        leaveProgram = true;
                        break;
                    }
                    else if (modeInput != 1 || modeInput != 2 || modeInput != 3)
                    {
                        Console.Clear();
                        Console.WriteLine("#################################");
                        Console.WriteLine("Invalid input... Please try again");
                        Console.WriteLine("#################################");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("#################################");
                    Console.WriteLine("Invalid input... Please try again");
                    Console.WriteLine("#################################");
                }
               
            }

        }
        public static bool paper = false;
        public static bool scissors = false;
        public static bool rock = false;
        public static void BestOfThree()
        {
            if (bestOutOfThree == true)
            {
            rock = false;
            paper = false;
            scissors = false;
            int cpuWins = 0;
            int userWins = 0;
                Random rand = new Random();
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("########################");
                        Console.WriteLine("Rock, Paper, or Scissors");
                        Console.WriteLine("########################");
                        Console.WriteLine("1. Rock");
                        Console.WriteLine("2. Paper");
                        Console.WriteLine("3. Scissors");
                        Console.WriteLine("########################");



                        if (int.TryParse(Console.ReadLine(), out int modeInput))
                        {

                            if (modeInput == 1)
                            {
                                rock = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput == 2)
                            {
                                paper = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput == 3)
                            {
                                scissors = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput != 1 || modeInput != 2 || modeInput != 3)
                            {
                                Console.Clear();
                                Console.WriteLine("#################################");
                                Console.WriteLine("Invalid input... Please try again");
                                Console.WriteLine("#################################");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("#################################");
                            Console.WriteLine("Invalid input... Please try again");
                            Console.WriteLine("#################################");
                        }
                    }
                    //1 rock
                    //2 scissors
                    //3 paper
                    Console.Write("Rock... ");
                    Thread.Sleep(1000);
                    Console.Write("Paper... ");
                    Thread.Sleep(1000);
                    Console.Write("Scissors... ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Shoot!!! ");
                    Thread.Sleep(1000);
                    int computerCheck = rand.Next(1, 3);
                    if (computerCheck == 1 && scissors == true)
                    {
                        cpuWins += 1;
                        Console.WriteLine("You lost this round...try again!");
                    }
                    else if (computerCheck == 2 && scissors == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                    else if (computerCheck == 3 && scissors == true)
                    {
                        Console.WriteLine("You won this round!!!");
                        userWins += 1;
                    }
                    else if (computerCheck == 1 && rock == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                    else if (computerCheck == 2 && rock == true)
                    {
                        Console.WriteLine("You won this round!!!");
                        userWins += 1;
                    }
                    else if (computerCheck == 3 && rock == true)
                    {
                        Console.WriteLine("You lost this round... Try again!");
                        cpuWins += 1;
                    }
                    else if (computerCheck == 1 && paper == true)
                    {
                        Console.WriteLine("You won this round!!!");
                        userWins += 1;
                    }
                    else if (computerCheck == 2 && paper == true)
                    {
                        Console.WriteLine("You lost this round... Try again!");
                        cpuWins += 1;
                    }
                    else if (computerCheck == 3 && paper == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                    if (cpuWins == 3)
                    {
                        Console.WriteLine("You lose... Try again next time");
                        Console.WriteLine("Enter anything to go back to the title screen");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else if (userWins == 3)
                    {
                        Console.WriteLine("Yay!!! YOU WON!");
                    }
                }
            }
        }


        public static void EndlessMode()
        {
            if (endless == true)
            {
                rock = false;
                paper = false;
                scissors = false;
                bool end = false;
                Random rand = new Random();
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("########################");
                        Console.WriteLine("Rock, Paper, or Scissors");
                        Console.WriteLine("########################");
                        Console.WriteLine("1. Rock");
                        Console.WriteLine("2. Paper");
                        Console.WriteLine("3. Scissors");
                        Console.WriteLine("4. Return to title screen");
                        Console.WriteLine("########################");



                        if (int.TryParse(Console.ReadLine(), out int modeInput))
                        {


                            if (modeInput == 1)
                            {
                                rock = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput == 2)
                            {
                                paper = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput == 3)
                            {
                                scissors = true;
                                Console.Clear();
                                break;
                            }
                            else if (modeInput == 4)
                            {
                                end = true;
                                break;
                            }
                            else if (modeInput != 1 || modeInput != 2 || modeInput != 3)
                            {
                                Console.Clear();
                                Console.WriteLine("#################################");
                                Console.WriteLine("Invalid input... Please try again");
                                Console.WriteLine("#################################");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("#################################");
                            Console.WriteLine("Invalid input... Please try again");
                            Console.WriteLine("#################################");
                        }
                    }
                    if (end == true)
                    {
                        Console.Clear();
                        break;
                    }
                    //1 rock
                    //2 scissors
                    //3 paper
                    Console.Write("Rock... ");
                    Thread.Sleep(1000);
                    Console.Write("Paper... ");
                    Thread.Sleep(1000);
                    Console.Write("Scissors... ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Shoot!!! ");
                    Thread.Sleep(1000);
                    int computerCheck = rand.Next(1, 3);
                    if (computerCheck == 1 && scissors == true)
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computerCheck == 2 && scissors == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                    else if (computerCheck == 3 && scissors == true)
                    {
                        Console.WriteLine("You win!!!");
                    }
                    else if (computerCheck == 1 && rock == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                    else if (computerCheck == 2 && rock == true)
                    {
                        Console.WriteLine("You win!!!");
                    }
                    else if (computerCheck == 3 && rock == true)
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computerCheck == 1 && paper == true)
                    {
                        Console.WriteLine("You win!!!");
                    }
                    else if (computerCheck == 2 && paper == true)
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computerCheck == 3 && paper == true)
                    {
                        Console.WriteLine("Tie...");
                    }
                }
            }
        }
    }        
}

