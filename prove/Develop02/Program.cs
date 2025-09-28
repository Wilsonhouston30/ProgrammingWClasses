using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");


        static void Display()
        {
            string [] Menu = {"Add Entry", "Display Entries", "load Journal", "Save Jounal", "End"};

            for (int i = 0; i< Menu.Length; i++)
            {
                Console.WriteLine($"{i +1}: {Menu[i]}");
            }

        }

            Journal journal1 = new Journal();
            int selection = -1;

       while (selection != 5)
       {
        Display();
        Console.Write("Select One - > ");
        selection = Int32.Parse(Console.ReadLine());
        
        if (selection == 1) // add entry to current journal
        {
            journal1.newEntry();
        }
        else if ( selection == 2) // load current sesh journal
        {
            journal1.Display();
        }
        else if ( selection == 3) // load journal
        {
            journal1.loadFiles();
        }
        else if (selection == 4) // save journal 
        {
            journal1.SaveEntry();
        }
       }









        
    }
}