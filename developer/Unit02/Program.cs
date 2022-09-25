using System;
using System.Collections.Generic;
namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = GetNewBoard();
            Console.WriteLine(board);
        }

        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <=9; i++)
            {
                board.Add(i.ToString());
            }

            return board;

        }
    }
}
