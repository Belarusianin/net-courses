using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you choose : guess or to make guess? Put 1 or 2 if yot want");
            string choose = Console.ReadLine();
            choose = choose.ToLower();
            int chooseNumber;
            if (int.TryParse(choose,out chooseNumber))
            {
                chooseNumber = int.Parse(choose);
            }

            if(choose == "guess" || chooseNumber == 1)
            {
                Guess();
            }
            else if(choose == "make guess" || chooseNumber == 2)
            {
                MakeGuess();
            }
        }

        static void Guess()
        {
            MakeByMachine humanTry = new MakeByMachine();
            humanTry.HumanTry();
        }

        static void MakeGuess()
        {
            Console.WriteLine("Make a guess. It should be less than 100 and more than 0");
            int number = int.Parse(Console.ReadLine());
            MakeByHuman machineTry = new MakeByHuman(number);
            machineTry.MachineTry(0,100);
        }
    }
}
