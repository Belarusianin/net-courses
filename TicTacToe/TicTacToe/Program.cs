using System;

namespace TicTacToe
{
    class Program
    {
        static Game game = new Game();

        static void Main(string[] args)
        {
            int index;
            PrintBoard();
            while (game.GetWinner() == Winner.Unfinished )
            {
                index = int.Parse(Console.ReadLine());
                game.MakeMove(index);

                Console.WriteLine();
                PrintBoard();
            }

            Console.WriteLine($"{game.GetWinner()} win");
        }

        static void PrintBoard()
        {
            for (int i = 1; i <= 7; i+=3)
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine($" {GetPrintChar(i)} | {GetPrintChar(i+1)} | {GetPrintChar(i+2)} ");
                Console.WriteLine("___|___|___");
            }
        }

        static string GetPrintChar(int index)
        {
            if(game.GetState(index) == State.Unset)
            {
                return index.ToString();
            }
            return game.GetState(index) == State.Cross ? "X" : "O";
        }
    }
}
