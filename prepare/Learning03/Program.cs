using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction wholenumber = new Fraction(1);
        Console.WriteLine(wholenumber.GetDecimalValue());
        Console.WriteLine(wholenumber.GetFraction());
        Fraction wholenumber1 = new Fraction(6,1);
        Console.WriteLine(wholenumber1.GetDecimalValue());
        Console.WriteLine(wholenumber1.GetFraction());
        Fraction wholenumber2 = new Fraction(1,3);
        Console.WriteLine(wholenumber2.GetDecimalValue());
        Console.WriteLine(wholenumber2.GetFraction());
    }
}