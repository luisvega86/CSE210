using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");

            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            while (MagicNumber != guess)

                {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                

                if (guess < MagicNumber)
                {
                    Console.WriteLine("Higher.");
                }

                else if (guess > MagicNumber)
                {
                    Console.WriteLine("Lower.");
                }

                else 
                {
                    Console.WriteLine("You guessed right! Well done!");
                }

            }

            


        }
    }
}
