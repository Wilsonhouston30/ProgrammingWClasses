public class Team
{
    private string _teamName;
    private List<People> _players = new List<People>();
    

    public Team(string teamName)
    {
        _teamName = teamName;
    }

    public Team()
    {
        _teamName = "Unassigned";
    }

    public void SetTeamName(string teamName)
    {
        _teamName = teamName;
    }

    public string GetTeamName()
    {
        return _teamName;
    }

    public void AddCoach()
    {

        Coach coach1 = new Coach();
        coach1.GetCoachInfo();
        _players.Add(coach1);

    }

    public void AddPlayer()
    {
        Player player1 = new Player();
        player1.GetAllPlayerInfo();
        _players.Add(player1);
    }

    public void RemovePlayer()
    {
        for (int i = 0; i< _players.Count; i++)
        {
            if (_players[i] is Player player)
            {
                Console.WriteLine($"{i}: {player.GetFName()}");
            }
        }
        Console.WriteLine("");
        Console.Write("Enter number");
        int removedPlayer = Int32.Parse(Console.ReadLine());

        _players.RemoveAt(removedPlayer);
    }

    public void RemoveCoach()
    {
        for (int i = 0; i< _players.Count; i++)
        {
            if (_players[i] is Coach coach)
            {
                Console.WriteLine($"{i}: {coach.GetFName()}");
            }
        }
        Console.WriteLine("");
        Console.Write("Enter number");
        int removedPlayer = Int32.Parse(Console.ReadLine());

        _players.RemoveAt(removedPlayer);
    }

    public List<People> GetPlayer()
    {
        return _players;
    }

    public void RosterView()
    {
        Console.WriteLine($"{GetTeamName()}:");
        Console.WriteLine("");
        Console.WriteLine("Coaches:");
        foreach(People person in _players)
        {
            if (person is Coach)
            {
                Console.Write("> ");
                person.Displayinfo();
                Console.WriteLine("");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Players:");
        foreach (People person in _players)
        {
            if ( person is Player )
            {
                Console.Write("> ");
                person.Displayinfo();
                Console.WriteLine("");
            }
        }
    }
    public void Save()
    {
        string fileName = $"{GetTeamName()}_Roster.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"---- {GetTeamName()} -----");
            outputFile.WriteLine($"Coaches: ");
            outputFile.WriteLine("");
            foreach(People people in _players)
            {
                
                if (people is Coach coach)
                {
                outputFile.WriteLine($"{coach.GetFName()} {coach.GetLname()}");
                outputFile.WriteLine();
                }
            }

            outputFile.WriteLine();
            outputFile.WriteLine($"Players: ");
            outputFile.WriteLine("");
            foreach(People people in _players)
            {
                if (people is Player player)
                {
                    outputFile.WriteLine($"{player.GetFName()} {player.GetLname()} #{player.GetNumber()} Pos.{player.GetPosition()}");
                    outputFile.WriteLine($"Height: {player.GetHeight()}");
                    outputFile.WriteLine("");
                }
            }
        }
        Console.WriteLine("Team Saved");
    }

    public void LoadTeam()
    {
        _players.Clear();
        Console.WriteLine();
        string name = $"{GetTeamName()}_Roster.txt";
        
        string [] lines  = System.IO.File.ReadAllLines(name);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("Team Loaded");
    }

    public List<Player> ListOfPlayers()
    {
        List<Player> players = new List<Player>();
        foreach(People people in _players)
        {
            if (people is Player player)
            {
                players.Add(player);
            }
        }
        return players;
    }


}