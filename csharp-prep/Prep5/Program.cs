using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 5");

            DisplayWelcome();

            string UserName = PromptUserName();
            int UserNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(UserNumber);
            DisplayResult(UserName, squaredNumber);





        }


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int PromptUserNumber()

        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, your squared number is: {square}.");
        }

        // {
        //     Console.Write("Please enter your favorite number: ");
        //     int number = int.Parse(Console.ReadLine());

        //     return number;
        // }

        
    }
}
