// See https://aka.ms/new-console-template for more information

char letterA = 'a';
double myMoney = 300.53;
decimal physicsVectorPrecise = 0.3332372742m;
bool randBool = true;
//just some goofy stuff
Console.WriteLine("Do you have a dog? ");

string havePet;
havePet = Convert.ToString(Console.ReadLine());

bool dogStatus;
while (true)
{
    if (havePet == "Yes" || havePet == "yes")
    {
        dogStatus = true;
        break;
    }
    else if (havePet == "No" || havePet == "no")
    {
        dogStatus = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid input... Try again: ");
        havePet = Convert.ToString(Console.ReadLine());
    }
}

int petAge;
petAge = 2;
if (dogStatus == true)
{
    Console.WriteLine("How old is your dog?");
    
    petAge = Convert.ToInt32(Console.ReadLine());
    bool ageVerify;

    while (true)
    {
        if (petAge >= 0 && petAge <= 25)
        {
            ageVerify = true;
            break;
        }
        else
        {
            Console.WriteLine("Thats Impossible!");
            petAge = Convert.ToInt32(Console.ReadLine());

        }
    }
}
else
{
    Console.WriteLine("Aww thats sad... You need a dog. ");
}
string dogName;
dogName = "Jack";
if (dogStatus == true)
{
    Console.WriteLine("What is your dogs name? ");

    
    dogName = Convert.ToString(Console.ReadLine());

}

if (dogStatus == true)
{
    Console.WriteLine($"Your dogs name is {dogName} and he is {petAge} years old!");
}





Console.WriteLine("Do you want to see some random stuff???");
string RandStr = Convert.ToString(Console.ReadLine());
bool yesRand;
while (true)
{
    if (RandStr == "Yes" || RandStr == "yes")
    {
        yesRand = true;
        break;
    }
    else if (RandStr == "No" || RandStr == "no")
    {
        yesRand = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid input... Try again: ");
        RandStr = Convert.ToString(Console.ReadLine());
    }
}
if (yesRand == true) ;
{
    Console.WriteLine($"Random stuff in three, two, one....                       LET IT BEGIN!!! {letterA}, {randBool}, {physicsVectorPrecise}, {myMoney}");
}