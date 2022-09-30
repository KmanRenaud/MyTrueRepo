using System.Linq;

//This one is FUN!

List<string> gameNames = new List<string>() 
{
    "Destiny 2",
    "Dark Souls",
    "Call of Duty",
    "Minecraft",
    "Rocket League",
    "God of War",
    "Fortnite",
    "Apex",
    "Valorant",
    "League of Legends"
};

int i = 1;

gameNames.OrderBy(x => x.Length)
         .ToList()
         .ForEach(x => Console.WriteLine($"Game number {i++}: {x}"));


#region

//LINQ is the BOMBBBBB

#endregion
