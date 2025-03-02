namespace GC_Test_2;

using System;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        
        
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        
        
        Console.WriteLine($"Welcome {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        var response = Console.ReadLine()!.Trim().ToLower(); // Normalize input

        if (response != "yes")
        {
            Console.WriteLine($"You are a coward {name}");
            return; 
        }

        
        int score = 0;
        Random random = new Random();

        for (int i = 0; i < 5; i++) 
        {
            int coinFlip = random.Next(2); 

            Console.WriteLine("Heads or Tails?");
            var userGuess = Console.ReadLine()!.Trim().ToLower(); t
            
           
            int userChoice = (userGuess == "heads") ? 0 : 1;

            if (userChoice == coinFlip)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        
        Console.WriteLine($"Thank you {name}. You got a score of {score}!");
    }
}
