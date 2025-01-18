using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        while(guess != magicNumber)
        {
            Console.WriteLine("Guess the Magic Number");
            Console.Write("Your Guess: ");
            guess = int.Parse(Console.ReadLine());

            if(guess < magicNumber){
                Console.WriteLine("Higher");
            }else if(guess > magicNumber){
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You Guessed it!");
        
    }
}