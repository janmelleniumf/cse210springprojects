using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess My Number Game!");
        Console.WriteLine("What is your nickname? ");
        string nickname = Console.ReadLine();


        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine($"Hi {nickname}, you need to guess the magic number from 1 - 100.");



            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int userGuess = 0;
            int totalGuess = 0;
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                totalGuess++;

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! After {totalGuess} times.");
                    
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes");

        }
    
        Console.WriteLine("Thank you for playing! Have a great day!");   
            
    }
}   