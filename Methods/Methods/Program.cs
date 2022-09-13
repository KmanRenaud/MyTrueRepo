// See https://aka.ms/new-console-template for more information


using System.Reflection.PortableExecutable;

class CallMethod
{
    //making the methods
    static void Add(List<int> adds)
    {
        int sum = 0; 

        for (int i = 0; i < adds.Count; i++)
        {
            sum += adds[i];
        }

        Console.WriteLine($"The total of all of the numbers is {sum}");
    }
    static void Sub(List<int> subs)
    {
        int min = subs[0];
        for (int x = 1; x < subs.Count; x ++)
        {
            min -= subs[x];
         }
        Console.WriteLine($"The subtraction of all the numbers is {min}");
    }
    static void Mult(List<int> mults)
    {
        int times = mults[0];
        for (int x = 0; x < mults.Count; x ++)
        {
            times *= mults[x];
        }
        Console.WriteLine($"The numbers multiplied are {times / mults[0]}");
    }
    static void Div(List<int> divs)
    {
        int dBy = divs[0];
        for (int x = 1; x < divs.Count; x ++)
        {
            dBy /= divs[x];

        }
        Console.WriteLine($"The leftover of all of the numbers is {dBy}");
    }
    static void Mod(List<int> mods)
    {
        int rem = mods[0];
        for (int x = 1; x < mods.Count; x ++)
        {
            rem %= mods[x];
        }
        Console.WriteLine($"The remainder of all of the numbers is {rem}");

    }
    static void Main(string[] args)
    {
        //first name
        Console.WriteLine("What is your first name? (click enter to skip...)");
        string firstName = Console.ReadLine();

        //middle name
        Console.WriteLine("What is your middle name? (click enter to skip...)");
        string middleName = Console.ReadLine();

        //last name
        Console.WriteLine("What is you last name? (click enter to skip...)");
        string lastName = Console.ReadLine();

        //maths:)
        var list = new List<int>();
        while (true)
        {
            Console.WriteLine("Please enter a number: ");
            int theirNumArray = Convert.ToInt32(Console.ReadLine());  
            list.Add(theirNumArray);
            Console.WriteLine("Would you like to add more numbers? (type yes or no)");
            string userResponce = Console.ReadLine().ToLower();
            if (userResponce != "yes")
            {
                break;
            }
        }


        //calling the methods
        Console.WriteLine($"Hello {firstName} {middleName} {lastName}! The numbers you inputed will show below...");
        CallMethod.Add(list);
        CallMethod.Sub(list);
        CallMethod.Mult(list);
        CallMethod.Div(list);
        CallMethod.Mod(list);

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



