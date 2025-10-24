using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine("Polymorphism prep");

        Square Square1 = new Square("blue", 2.5);
        Console.WriteLine(Square1.GetColor());
        Console.WriteLine(Square1.GetArea());

        Rectangle rectangle1 = new Rectangle(5,5,"blue");
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());


    }
}