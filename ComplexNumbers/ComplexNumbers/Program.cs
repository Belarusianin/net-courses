using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 2);
            a.Print();
            a.Add(b);
            a.Print();
            a.Subtraction(b);
            a.Print();
            a.Multiply(b);
            a.Print();
            b.Print();
        }
    }
}
