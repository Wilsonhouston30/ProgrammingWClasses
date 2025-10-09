using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    { 
        var rand = new Random();
        
        foreach (string text in File.ReadAllLines("scripturelibrary.txt"))
        {
            string [] script = text.Split(",",StringSplitOptions.None);

            Console.WriteLine(script[4]);
        }
                Console.ReadLine();
        Console.Clear();
    }

}