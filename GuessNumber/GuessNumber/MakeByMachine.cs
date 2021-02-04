using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class MakeByMachine
    {
        int number = GetRandom();

        public void Print()
        {
            Console.WriteLine(number);
        }

        static int GetRandom()
        {
            Random random = new Random();
            int value = random.Next(0,100);
            return value;
        }

        public void HumanTry()
        {
            int counter = 0, tryNumber;
            while (counter < 5)
            {
                Console.WriteLine("Try to guess a number,it from 0 to 100 : ");
                if (int.TryParse(Console.ReadLine(), out tryNumber))
                {
                    counter++;
                    
                    if(tryNumber == number)
                    {
                        Console.WriteLine("You guess , congratulations");
                        return;
                    }
                    else if (tryNumber < number)
                    {
                        Console.WriteLine($"The number is bigger than your , you have {5 - counter} chances");
                    }
                    else if (tryNumber > number)
                    {
                        Console.WriteLine($"The number is smaller than your , you have {5 - counter} chances");
                    }

                }
                else
                    Console.WriteLine("You enter the wrong number, try again : ");
            }
            Console.WriteLine("You lose , you don't have any chances");

        }

    }
}
