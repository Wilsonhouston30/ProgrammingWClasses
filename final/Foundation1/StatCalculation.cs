public class StatCalulations
{
    private int _shotsMade;
    private int _shotsAttempted;

    public int ShotsMade
    {
        get{return _shotsMade;}
        set{_shotsMade = value;}
    }
    public int ShotsAttempted
    {
        get{return _shotsAttempted;}
        set{_shotsAttempted = value;}
    }

    public StatCalulations(int shotsAttempted, int shotsMade)
    {
        _shotsAttempted = shotsAttempted;
        _shotsMade = shotsMade;
    }


    public double FGPercentage()
    {
        return (double)_shotsAttempted / _shotsMade;
    }
    


}