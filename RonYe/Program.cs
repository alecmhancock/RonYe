using System;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;


var ronScore = 0;
var yeScore = 0;
var client = new HttpClient();
var quote = new RonYe.QuoteGen(client);

Console.WriteLine("Let's play RonYe!");

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    
    bool again = true;
    while (again)
    {
        Console.WriteLine($"Kanye: {quote.Kanye()}");

        Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");

        Console.WriteLine();

        Console.WriteLine($"Round {i + 1}: Who won this round, Kanye or Ron Swanson?");
        var userInput = Console.ReadLine().ToLower();
        again = false;

        switch (userInput.ToLower())
        {
            case "ron swanson": ronScore++;
                break;
            case "ron": ronScore++;
                break;
            case "kanye": yeScore++;
                break;
            case "ye": yeScore++;
                break;
            default:
                again = true;
                break;
        }
    }
    
}
Console.WriteLine();
Console.WriteLine($"Ron's Score: {ronScore}");
Console.WriteLine();
Console.WriteLine($"Kayne's Score: {yeScore}");

if (ronScore > yeScore)
{
    Console.WriteLine("Ron Swanson wins again.");
}

else if (yeScore > ronScore)
{
    Console.WriteLine("Ye reigns supreme.");
}

else
{
    Console.WriteLine("Well this is a logic bug. How's your day going? Getting enough sleep?.");
}