using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        string name;
        char pin;

        public Player(char pin,string name)
        {
            this.pin = pin;
            this.name = name;
        }

        bool CheckNumber(int number)
        {
            for (int i = 0; i < 9; i++)
            {
                if ((number >= 10 || number < 0) || (Game.chests[number] == 'x' || Game.chests[number] == 'o'))
                {
                    Console.WriteLine("You put wrong number,please try again");
                    return false;
                }
            }
            return true;
        }

        public bool MakeMove()
        {
            Console.WriteLine($"{name} player put a number: ");
            int number = int.Parse(Console.ReadLine()) - 1;

            if (CheckNumber(number))
            {
                Game.chests[number] = pin;
                return false;
            }
            return true;
        }



    }
}
