using System;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Program W05");

        static void DisplayMenu()
        {
            string [] menu = ["Create new Goal", "List Goal", "Save Goal", "Load Goal", "Record Event", "Quit"];
            Console.WriteLine("Menu -> Select one");
            for(int i = 0; i <menu.Length; i++)
            {
                Console.WriteLine($"{i+1}: {menu[i]}");
            }
            Console.Write("-> ");
        }

        int userInput = -1;
        Goal goal1 = new Goal()
 

        while (userInput != 5)
        {
            DisplayMenu();
            userInput = -1;
            userInput = Int32.Parse(Console.ReadLine());
            if(userInput == 1)
            {
                Console.WriteLine("Create new Goal");


            }
            else if (userInput ==2)
            {
                Console.WriteLine("Check2");

            }
            else if (userInput ==3)
            {
                Console.WriteLine("Check3");
            }
            else if (userInput ==4)
            {
                Console.WriteLine("Check4");
            }
            else
            {
                Console.WriteLine("Please select again");
            }
        }




    }
}