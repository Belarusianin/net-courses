using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class MakeByHuman
    {
        public int number;

        public int Number
        {
            set
            {
                if (number < 100 && number > 0)
                    number = value;
                else
                    Console.WriteLine("A number should be less than 100 and more than 0");
            }
        }

        public MakeByHuman(int number)
        {
            this.number = number;
        }

        static int counter = 0;
        int tryNumber;
        char direction;
        public int MachineTry(int begin ,int end)
        {
            tryNumber = (end + begin) / 2;
            if(tryNumber == number)
            {
                Console.WriteLine($"Machine guess. The number was {number}");
                return 0;
            }

            if(counter == 5)
            {
                Console.WriteLine("You win ,congratulation");
                return 0;
            }

            counter++;
            Console.WriteLine($"This number is more than {tryNumber} ? Put 'y' or '1' if YES and 'n' or '0' if NO");
            direction = char.Parse(Console.ReadLine());

            if (direction == '1' || direction == 'y')
            {
                return MachineTry((begin + end) / 2, end);
            }
            else if(direction == '0' || direction == 'n')
            {
                return MachineTry(begin, (begin + end) / 2);
            }

            Console.WriteLine("You put invalid value. Try once again");
            counter--;
            return MachineTry(begin, end);
        }
    }
}
