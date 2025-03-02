namespace GC_Test_2;

using System;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        
        // Ask for the user's name
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        
        // Ask if they want to do the challenge
        Console.WriteLine($"Welcome {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        var response = Console.ReadLine()!.Trim().ToLower(); // Normalize input

        if (response != "yes")
        {
            Console.WriteLine($"You are a coward {name}");
            return; // End the program
        }

        // Start the coin flip challenge
        int score = 0;
        Random random = new Random();

        for (int i = 0; i < 5; i++) // Loop 5 times
        {
            int coinFlip = random.Next(2); // Generates 0 or 1 (0 = Heads, 1 = Tails)

            Console.WriteLine("Heads or Tails?");
            var userGuess = Console.ReadLine()!.Trim().ToLower(); // Normalize input
            
            // Convert user input into a comparable number (0 = Heads, 1 = Tails)
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

        // End of game: Show final score
        Console.WriteLine($"Thank you {name}. You got a score of {score}!");
    }
}