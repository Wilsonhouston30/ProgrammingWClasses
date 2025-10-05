using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    { 
        string userinput = " ";
        Console.Write("Enter the verse you want to work on: ");  
        string verse = Console.ReadLine();
        Console.WriteLine("Enter the book: ");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter: ");
        string chapter = Console.ReadLine(); 
        Console.WriteLine("Enter the verse number");
        string verseNum = Console.ReadLine();
        Scripture scripture = new Scripture(book,chapter,verseNum,verse);
        
        Console.ReadLine();
        Console.Clear();

        bool completed = false;

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