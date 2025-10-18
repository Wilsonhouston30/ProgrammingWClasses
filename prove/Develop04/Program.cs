using System;

class Program
{
    static void Main(string[] args)
    {

        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Please select one: ");
            string [] _menu = {"Listening", "Refelection", "Breathing", "Quit"};
            for  (int i = 0; i <_menu.Length; i++ )
            {
                Console.WriteLine($"{i +1}: {_menu[i]} Activity");
            }
        }

        Loading loading1 = new Loading();

        int selection = 0;
        while (selection != 4)
        {
            Menu();
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                ListeningActivity listeningActivity1 = new ListeningActivity(0);
                loading1.LoadAnimation();
                listeningActivity1.StartListeningActivity();
                listeningActivity1.EndingMessage();
            }
            else if (selection == 2)
            {
                ReflectingActivity reflectionActivity1 = new ReflectingActivity(0);
                loading1.LoadAnimation();
                reflectionActivity1.StartReflectingActivity();
                reflectionActivity1.EndingMessage();

            }
            else if (selection == 3)
            {
                BreathingActivity breathing1 = new BreathingActivity(0);
                loading1.LoadAnimation();
                breathing1.StartBreathingActivity();
                breathing1.EndingMessage();

            }
            else if (selection == 4)
            {
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