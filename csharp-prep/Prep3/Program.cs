using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?");
        // string magicStringNumber = Console.ReadLine();
        // int magicNumber = int.Parse(magicStringNumber);
          
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guessNumber; 
        do
        {
            Console.Write("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());

            if(guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessNumber != magicNumber );

        
        
    }
}