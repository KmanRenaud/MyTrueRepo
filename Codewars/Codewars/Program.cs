using System;
using System.Linq;



string sentence = "Hello World";

var arr = sentence.Split(' ');

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length > 4)
    {
        var arr1 = arr[i].Reverse().ToArray();

        arr[i] = "";
        foreach (var item in arr1)
        {
            arr[i] += item;
        }
    }
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}
string str = "";
foreach (var i in arr)
{
    str += $"{i} ";
}

str.Remove(str.Length - 1);

Console.WriteLine(str);