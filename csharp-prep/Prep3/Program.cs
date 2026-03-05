using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("I know a magic number. Can you guess what it is? ");

        int guess = 0;

        while (guess != magicNumber)
        {
                Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if ( guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            } else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            } else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}