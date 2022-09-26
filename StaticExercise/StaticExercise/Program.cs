using System.Threading;
using System;
using StaticExercise;


Console.WriteLine("C to F");
Console.WriteLine(Math.Round(TempConverter.CtoF(55), 1));
Console.WriteLine();


Thread.Sleep(3000);


Console.WriteLine("F to C");
Console.WriteLine(Math.Round(TempConverter.FtoC(55), 1));
Console.WriteLine();
