using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction fraction = new Fraction();
       fraction.SetTop(3);
       fraction.SetBottom(4);
       Fraction f = new Fraction(8);
       Fraction frac = new Fraction(2, 7);
       Console.WriteLine(fraction.GetFractionString());
       Console.WriteLine(fraction.GetDecimalValue());
       Console.WriteLine(f.GetFractionString());
       Console.WriteLine(f.GetDecimalValue());
       Console.WriteLine(frac.GetFractionString());
       Console.WriteLine(frac.GetDecimalValue());
       
    }
}