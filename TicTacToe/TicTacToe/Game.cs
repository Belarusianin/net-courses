using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        public static char[] chests = new char[9];

        public Game()
        {
            for (int i = 0; i < 9; i++)
            {
                chests[i] = '_';
            }
            Console.WriteLine("Put numbers form 1 to 9");
        }

        public static void Print()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine();
                Console.Write(chests[i] + "\t");
            }
            Console.WriteLine();
        }

        bool Combination()
        {
            if ((chests[0] == chests[4] && chests[0] == chests[8] && chests[0] != '_') || (chests[2] == chests[4] && chests[2] == chests[6] && chests[2] != '_'))
            {
                return true;
            }
            else if ((chests[0] == chests[1] && chests[0] == chests[2] && chests[0] != '_') || (chests[3] == chests[4] && chests[3] == chests[5] && chests[3] != '_') || (chests[6] == chests[7] && chests[6] == chests[8] && chests[6] != '_'))
            {
                return true;
            }
            else if ((chests[0] == chests[3] && chests[0] == chests[6] && chests[0] != '_') || (chests[1] == chests[4] && chests[1] == chests[7] && chests[1] != '_') || (chests[2] == chests[5] && chests[2] == chests[8] && chests[2] != '_'))
            {
                return true;
            }

            return false;
        }

        bool CheckNumber(int number)
        {
            for (int i = 0; i < 9; i++)
            {
                if ((number >= 10 || number < 0) || (chests[number] == 'x' || chests[number] == 'o'))
                {
                    Console.WriteLine("You put wrong number,please try again");
                    return false;
                }
            }
            return true;
        }

        public void PlayGame()
        {
            Player playerX = new Player('x',"First");
            Player playerO = new Player('o',"Second");
            int counter = 0;

            while (counter < 9)
            {
                Print();
                if(counter % 2 == 0)
                {
                    if (playerX.MakeMove())
                    {
                        continue;
                    }

                    if (Combination())
                    {
                        Print();
                        Console.WriteLine("First player win");
                        break;
                    }

                    counter++;
                }
                else
                {
                    if (playerO.MakeMove())
                    {
                        continue;
                    }

                    if (Combination())
                    {
                        Print();
                        Console.WriteLine("Second player win");
                        break;
                    }

                    counter++;
                }
            }

            if (!Combination() && counter == 9)
            {
                Console.WriteLine("Draw");
            }

        }
    }
}
