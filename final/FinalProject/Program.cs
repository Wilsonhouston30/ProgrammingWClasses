using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the StatManager Program!");

        static void DisplayMenu()
        {
            string [] menu = ["Manage Team", "Manage Stats","Quit"];
            Console.WriteLine("Menu");
            Console.WriteLine("");
            for(int i = 0; i <menu.Length; i++)
            {
                Console.WriteLine($"{i+1}: {menu[i]}");
            }
            Console.Write("Select one: -> ");
        }


        int menuSelection = 0;
        Loading loading1 = new Loading();

        while (menuSelection != 3)
        {
            DisplayMenu();
            menuSelection = int.Parse(Console.ReadLine());
            if (menuSelection == 1)
            {
                loading1.LoadAnimation();
                static void TeamMenu()
                {

                    string [] menu = ["Add Player", "Add Coach","View Roster", "Remove Player", "Remove Coach", "Back to Menu"];
                    Console.WriteLine("Team Management");
                    Console.WriteLine("");
                    for(int i = 0; i <menu.Length; i++)
                    {
                        Console.WriteLine($"{i+1}: {menu[i]}");
                    }
                Console.Write("Select one: -> ");
                }
                    Console.Write("Team Name:");
                    string teamName = Console.ReadLine();
                    Team team1 = new Team(teamName);
                int teamManagmentSelection = 0;
                while (teamManagmentSelection != 6)
                {

                    TeamMenu();                   
                    teamManagmentSelection = int.Parse(Console.ReadLine());
                    if (teamManagmentSelection ==1)
                    {
                        team1.AddPlayer();
                    }
                    else if (teamManagmentSelection ==2)
                    {
                        team1.AddCoach();
                    }
                    else if (teamManagmentSelection ==3)
                    {
                        Console.WriteLine("View Roster");
                        team1.ShowWholeTeam();
                    }
                    else if (teamManagmentSelection ==4)
                    {
                        Console.WriteLine("Remove Player");
                    }
                    else if (teamManagmentSelection ==5)
                    {
                        Console.WriteLine("Remove Coach");
                    }
                    else if ( teamManagmentSelection == 5)
                    {
                        Console.WriteLine("Back to Menu");
                        loading1.LoadAnimation();
                    }
                }


            }
            else if (menuSelection == 2)
            {
                loading1.LoadAnimation();

            }
            else if (menuSelection == 3)
            {
                loading1.LoadAnimation();
                Console.WriteLine("Quit");
            }
            else
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Please enter number between 1-4");
            }
        }
        Console.WriteLine("Goodbye");




    }
}