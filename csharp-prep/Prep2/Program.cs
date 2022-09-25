using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            Console.Write("What is your grade percentage?: ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);

            string letter = "";

            if (percent >= 90)
            {
                letter = "A";            
            }

            else if (percent >= 80)
            {
                letter = "B";
            }

            else if (percent >= 70)
            {
                letter = "C";
            }

            else if (percent >= 60)
            {
                letter = "D";
            }

            else if (percent < 60)
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is {letter}");

            if (percent >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course!");
            }

            if (percent < 70)
            {
                Console.WriteLine("Your grade isn't enough to pass the course. Try again.");
            }
        }
    }
}
