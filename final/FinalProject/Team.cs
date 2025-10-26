public class Team
{
    private string _teamName;
    private DateOnly _date;
    private List<Player> _players = new List<Player>();

    public Team(string teamName, DateOnly date)
    {
        _teamName = teamName;
        _date = date;
    }

}