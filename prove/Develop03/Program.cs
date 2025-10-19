using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    { 
        var rand = new Random();
        
        string[] line =  File.ReadAllLines("scripturelibrary.txt");

        int randi = rand.Next(line.Length);
        string randl = line[randi];

        string [] script = randl.Split(",",5,StringSplitOptions.None);

        string book = script[1];
        string chapter = script[2];
        string verse = script[3];
        string words = script[4];

        Scripture scripture = new Scripture(book,chapter,verse,words);

        Console.ReadLine();
        Console.Clear();

        bool completed = false;
        string userinput = " ";

        while (!completed && userinput.ToUpper() != "QUIT")
        {

            Console.WriteLine(scripture.GetVerse());

            if (userinput.ToUpper() != "QUIT")
            {
                completed = scripture.HideScripture();
                userinput = Console.ReadLine();
                Console.Clear();
            }

        }
        Console.WriteLine("Done");

        Console.ReadKey();
    }

}