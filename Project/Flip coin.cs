using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string userChoice;
        string[] options = { "heads", "tails" };

        Console.WriteLine("Welcome to the Coin Flip Game!");
        
        while (true)
        {
            Console.Write("Enter your choice (heads/tails) or 'exit' to quit: ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "exit")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else if (userChoice != "heads" && userChoice != "tails")
            {
                Console.WriteLine("Invalid choice. Please enter 'heads' or 'tails'.");
                continue;
            }

            string flipResult = options[random.Next(0, 2)];
            Console.WriteLine($"The coin landed on: {flipResult}");
            
            if (userChoice == flipResult)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time.");
            }
        }
    }
}
