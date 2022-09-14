// See https://aka.ms/new-console-template for more information


using System.Reflection.PortableExecutable;

class CallMethod
{
    //making the methods
    static void Add(List<double> adds)
    {
        double sum = 0; 

        for (int i = 0; i < adds.Count; i++)
        {
            sum += adds[i];
        }

        Console.WriteLine($"The total of all of the numbers is {sum}");
    }
    static void Sub(List<double> subs)
    {
        double min = subs[0];
        for (int x = 1; x < subs.Count; x ++)
        {
            min -= subs[x];
         }
        Console.WriteLine($"The subtraction of all the numbers is {min}");
    }
    static void Mult(List<double> mults)
    {
        double times = mults[0];
        for (int x = 0; x < mults.Count; x ++)
        {
            times *= mults[x];
        }
        Console.WriteLine($"The numbers multiplied are {times / mults[0]}");
    }
    static void Div(List<double> divs)
    {
        double dBy = divs[0];
        for (int x = 1; x < divs.Count; x ++)
        {
            dBy /= divs[x];

        }
        Console.WriteLine($"The leftover of all of the numbers is {Math.Round(dBy, 2)}");
    }
    static void Mod(List<double> mods)
    {
        double rem = mods[0];
        for (int x = 1; x < mods.Count; x ++)
        {
            rem %= mods[x];
        }
        Console.WriteLine($"The remainder of all of the numbers is {rem}");

    }
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();
        Console.Clear();
        bool isCalTrue;
        while (true)
        {
            Console.WriteLine("Do you want to access the calculator? (yes or no)");
            string info = Console.ReadLine();
            if (info == "no" || info == "No")
            {
                Console.WriteLine("Oh well...");
                isCalTrue = false;
                break;
            }
            else if (info == "yes" || info == "Yes")
            {
                Console.WriteLine("Yay!!! Lets get started!");
                isCalTrue = true;
                break;
            }
            else if (info != "Yes" && info != "yes" && info != "No" && info != "no") 
            {
                Console.WriteLine("Invalid input... Please try again:");
            }
        }
        Console.Clear();
        //first name

        //maths:)
        if (isCalTrue == false)
        {
            while (true)
            {
                Console.WriteLine("Do you want to play a game? (yes or no)");
                
                string info1 = Console.ReadLine();
                if (info1 == "no" || info1 == "No")
                {
                    Console.Clear();
                    Console.WriteLine($"Well if you dont want to play a game let me ask you a question {Name}...");
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("How old is your dog?");
                    int ageDog = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------");
                    Console.Clear();
                    Console.WriteLine("Well, well, well... THOSE ANSWERS WERE CRITICAL TO MY PLAN... IM STEALING YOUR DATA");
                    Console.WriteLine("In 3!");
                    Console.WriteLine("2!");
                    Console.WriteLine("1!");
                    Console.Clear();
                    Console.WriteLine("######################\n" +
                                      "######################\n" +
                                      "#######CPU.INFO#######\n" +
                                      "####INITALIZING...####\n" +
                                      "####12%---15%---33%--#\n" +
                                      "##-64%--87%-99%...####\n" +
                                      "######################\n" +
                                      "######################\n");
                    Console.WriteLine($"Data.StealInfo.{Name}'sComputer COMPLETE!");
                    break;
                }
                else if (info1 == "yes" || info1 == "Yes")
                {
                    Console.Clear();
                    Console.WriteLine("That was easy... You entered my trap... Wait a few moments..." +
                                      "3...2...1");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("######################\n" +
                  "######################\n" +
                  "#######CPU.INFO#######\n" +
                  "####INITALIZING...####\n" +
                  "####12%---15%---33%--#\n" +
                  "##-64%--87%-99%...####\n" +
                  "######################\n" +
                  "######################\n");
                    Console.WriteLine($"Data.StealInfo.{Name}'sComputer COMPLETE!");
                    break;
                }
            }

        }
        else
        {
            var list = new List<double>();
            Console.WriteLine("Please enter a number: ");

            while (true)
            {
                double theirNumArray = Convert.ToDouble(Console.ReadLine());
                list.Add(theirNumArray);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Would you like to add more numbers? (type yes or no)");
                string userResponce = Console.ReadLine().ToLower();
                Console.WriteLine("--------------------------------------------------");
                if (userResponce == "yes")
                {
                    Console.WriteLine("Please enter a number: ");
                }
                else if (userResponce == "no")
                {
                    break;
                }
                else if (userResponce != "yes" && userResponce != "no")
                {
                    Console.WriteLine("Invalid input... Please enter a number: ");
                }
            }


            //calling the methods
            Console.WriteLine($"Hello {Name}! The numbers you inputed will show below...");
            Console.Write("Click enter to continue...");
            string a = Console.ReadLine();
            Console.Clear();
            CallMethod.Add(list);
            Console.WriteLine("--------------------------------------------------");
            CallMethod.Sub(list);
            Console.WriteLine("--------------------------------------------------");
            CallMethod.Mult(list);
            Console.WriteLine("--------------------------------------------------");
            CallMethod.Div(list);
            Console.WriteLine("--------------------------------------------------");
            CallMethod.Mod(list);
        }
        //This is for if I was the division to be a double
        //Console.WriteLine("Heres your division");
        ////maths:)
        //var list1 = new List<double>();
        //while (true)
        //{
        //    Console.WriteLine("Please enter a number: ");
        //    double theirNumArray1 = Convert.ToDouble(Console.ReadLine());
        //    list1.Add(theirNumArray1);
        //    Console.WriteLine("Would you like to add more numbers? (type yes or no)");
        //    string userResponce = Console.ReadLine().ToLower();
        //    if (userResponce != "yes")
        //    {
        //        break;
        //    }


        //}

    }
}



