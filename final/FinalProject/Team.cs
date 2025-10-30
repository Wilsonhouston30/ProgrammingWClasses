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

    public void RemovePlayer(Player player)
    {
        _players.Remove(player);
    }

    public List<People> GetPlayer()
    {
        return _players;
    }

    public void ShowWholeTeam()
    {
        Console.WriteLine($"{GetTeamName()}:");
        Console.WriteLine("");
        Console.WriteLine("Coaches:");
        foreach(People person in _players)
        {
            if (person is Coach)
            {
                person.Displayinfo();
                Console.WriteLine("______________");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Players:");

        foreach (People person in _players)
        {
            if ( person is Player )
            {
                person.Displayinfo();
                Console.WriteLine("______________");


            }
        }
    }


}