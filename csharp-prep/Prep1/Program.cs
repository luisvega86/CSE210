using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is prep 1");

            // Write your code here
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine($"My name is {lastname}, {name} {lastname}.");
        }
    }
}
