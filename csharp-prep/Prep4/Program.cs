using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");

            List<int> numbers = new List<int>();

            int input = -1;

            while (input != 0)
            {
                Console.Write("Please enter a number(type 0 to quit): ");
                input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }


            // sum

            int suma = 0;
            foreach (int number in numbers)
            {
                suma += number;
            }

            Console.WriteLine($"The sum is: {suma}");

            // average

            float average = suma / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // find max

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;                
                }
            }
            
            Console.WriteLine($"The max is: {max}");


        }
    }
}
