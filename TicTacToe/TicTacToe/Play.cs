using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Play
    {
        char[] chests = new char[9];

        void Start()
        {
            for (int i = 0; i < 9; i++)
            {
                chests[i] = '_';
            }
        }

        void Print()
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

        bool checkNumber(int number)
        {
            

            for (int i = 0; i < 9; i++)
            {
                if ((number >= 10 || number < 0)|| (chests[number] == 'x' || chests[number] == 'o'))
                {
                    Console.WriteLine("You put wrong number,please try again");
                    return false;
                }
            }

            return true;
        }

        
        public void PlayGame()
        {
            int number, counter = 0;

            bool end = true;
            
            Start();
            Console.WriteLine("Put 1 - 9");
            while (counter != 4) 
            {
                Print();
                while (true)
                {
                    Console.WriteLine("First player put a number : ");
                    number = int.Parse(Console.ReadLine());
                    number--;

                    if (checkNumber(number))
                    {
                        break;
                    }
                }

                chests[number] = 'x';

                if (Combination())
                {
                    Print();
                    Console.WriteLine("First player win");
                    end = false;
                    break;
                }

                Print();

                while (true)
                {

                    Console.WriteLine("Second player put a number : ");
                    number = int.Parse(Console.ReadLine());
                    number--;

                    if (checkNumber(number))
                    {
                        break;
                    }
                }

                chests[number] = 'o';

                if (Combination())
                {
                    Print();
                    Console.WriteLine("Second player win");
                    end = false;
                    break;
                }

                counter++;

            }

            if (end)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (chests[i] == '_')
                    {
                        chests[i] = 'x';
                    }
                }

                if (Combination())
                {
                    Print();
                    Console.WriteLine("First player win");
                }
                else
                {
                    Print();
                    Console.WriteLine("Draw");
                }
            }

        }
    }
}
