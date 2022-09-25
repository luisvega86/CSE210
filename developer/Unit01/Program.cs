namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = GetNewBoard();
            string currentPlayer = "x";

            while (!IsGameOver(board))
            {
                DisplayBoard(board);
                int choice = GetMoveChoice(currentPlayer);
                if (MakeMove(board, choice, currentPlayer))
                {
                    currentPlayer = GetNextPlayer(currentPlayer);
                }
            }
            DisplayBoard(board);
            GetGameResult(board);

            // Console.WriteLine("Good game. Thanks for playing!");
        }

        static void GetGameResult(List<string> board)
        {
            if (IsWinner(board, "o"))
            {
                Console.WriteLine("The winner is o!");
            }
            else if (IsWinner(board, "x"))
            {
                Console.WriteLine("The winner is x!");
            }
            else
            {
                Console.WriteLine("It's a Tie!");
            }

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

        static void DisplayBoard(List<string> board)
        {
            int counter = 0;

            for (int i = 0; i < board.Count; i++)
            {
                if (counter == 1)
                {
                    Console.WriteLine("-+-+-");
                    counter = 0;
                }

                Console.WriteLine($"{board[i]}|{board[i+1]}|{board[i+2]}");
                i = i + 2;
                counter++;

            }
        }

        static bool IsWinner(List<string> board, string player)
        {
            bool isWinner = false;

            //horizontal
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] == player && board[i+1] == player && board[i+2] == player)
                {
                    isWinner = true;
                    break;
                }
                i = i + 2;
            }

            //vertical
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == player && board[i+3] == player && board[i+6] == player)
                {
                    isWinner = true;
                    break;
                }
            }

            //diagonal
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    if (board[i] == player && board[i+4] == player && board[i+8] == player)
                    {
                        isWinner = true;
                        break;
                    }
                }
                else if (i == 2)
                {
                    if (board[i] == player && board[i+2] == player && board[i+4] == player)
                    {
                        isWinner = true;
                        break;
                    }
                }

                i++;
            }

            // if ((board[0] == player && board[1] == player && board[2] == player)
            //     || (board[3] == player && board[4] == player && board[5] == player)
            //     || (board[6] == player && board[7] == player && board[8] == player)
            //     || (board[0] == player && board[3] == player && board[6] == player)
            //     || (board[1] == player && board[4] == player && board[7] == player)
            //     || (board[2] == player && board[5] == player && board[8] == player)
            //     || (board[0] == player && board[4] == player && board[8] == player)
            //     || (board[2] == player && board[4] == player && board[6] == player)
            //     )
            // {
                // isWinner = true;
            // }

            return isWinner; 
        }

        static bool IsGameOver(List<string> board)
        {
            bool isGameOver = false;

            if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board))
            {
                isGameOver = true;
            }

            return isGameOver;
        }

        static bool IsTie(List<string> board)
        {
            bool foundDigit = false;

            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] != "x" && board[i] != "o")
                {
                    foundDigit = true;
                    break;
                }

            }

            

            return !foundDigit;
        }

        static string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }

        static int GetMoveChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();

            int choice = int.Parse(move_string);
            return choice;
        }

        static bool MakeMove(List<string> board, int choice, string currentPlayer)
        {
            
            int index = choice - 1;

            bool isValidMove = false;

            if (board[index] == "x" || board[index] == "o")
            {
                Console.WriteLine($"This field is already in use by {board[index]}");        
            
            }
            else
            {
                board[index] = currentPlayer;
                isValidMove = true;
            }

            return isValidMove;
        }




    }
}
