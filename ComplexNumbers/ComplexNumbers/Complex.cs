using System;

namespace ComplexNumbers
{
    class Complex
    {
        public int rez, imz;
        public Complex(int rez, int imz)
        {
            this.rez = rez;
            this.imz = imz;
        }

        public void Add(Complex number)
        {
            rez += number.rez;
            imz += number.imz;
        }

        public void Subtraction(Complex number)
        {
            rez -= number.rez;
            imz -= number.imz;
        }

        public void Multiply(Complex number)
        {
            rez = rez * number.rez - imz * number.imz;
            imz = rez * number.imz + number.rez * imz;
        }

        public void Print()
        {
            Console.WriteLine($"({rez},{imz})");
        }
    }
}
