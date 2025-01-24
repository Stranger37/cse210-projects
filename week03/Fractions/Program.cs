using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDecimalValue()}");
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}\n{fraction2.GetDecimalValue()}");
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDecimalValue()}");
        fraction1.SetTop(1);
        fraction1.SetBot(3);
        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDecimalValue()}");
    }
}