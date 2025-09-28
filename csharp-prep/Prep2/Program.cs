using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter class grade percentage: ");
        var userInput = Int32.Parse(Console.ReadLine());

        string grade = "";

        if (userInput >= 90)
        {
            grade = "A";
        }
        else if (userInput >= 80)
        {
            grade = "B";
        }
        else if (userInput >= 70)
        {
            grade = "C";
        }
        else if (userInput >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

    }
}