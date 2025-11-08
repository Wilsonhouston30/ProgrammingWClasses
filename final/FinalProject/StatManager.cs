public class StatManager
{

    private List<(Player player, Stats stats)> _statRecord = new List<(Player player, Stats stats)>();
    private Team _team;

    public StatManager(Team team)
    {
        _team = team;
    }
    public void SaveRecords()
    {
        List<Player> players=_team.ListOfPlayers();
        for (int i = 0; i< players.Count; i++)
        {
            Player player = players[i];
            Console.WriteLine($" {i}) {player.FName} {player.LName}");
        }

        Console.Write("Select Player to enter stats for: ");
        int playerSelection = Int32.Parse(Console.ReadLine());

        Player PS  = players[playerSelection];
        Stats stats = new Stats();
        stats.GetAllStats();

        _statRecord.Add((PS, stats));

        Console.WriteLine("Stats Added");
    }

    public void LoadRecords()
    {

    }

    public void DisplayRecords()
    {
        foreach(var record in _statRecord)
        {
            Player player = record.player;
            Stats stat = record.stats;
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }
}