using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        StatCalulations stats1 = new StatCalulations(5,20);
        Console.WriteLine($"%{stats1.FGPercentage()}");

    }
}