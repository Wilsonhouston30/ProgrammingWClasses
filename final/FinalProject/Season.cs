public class Season
{
    private DateOnly _date;
    private string _team;
    private int _wins;
    private int _losses;

    public DateOnly Date
    {
        get{return _date;}
        set{_date = value;}
    }

    public string Team
    {
        get{return _team;}
        set{_team = value;}
    }

    public int Wins
    {
        get{return _wins;}
        set{_wins = value;}
    }

    public int Losses
    {
        get{return _losses;}
        set{_losses = value;}
    }
}