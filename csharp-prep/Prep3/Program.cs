using System;

class Program
{
    static void Main(string[] args)
    {
         // For Parts 1 and 2, where the user gave the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }           
    }
}