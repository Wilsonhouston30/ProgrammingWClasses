using System.Reflection.Metadata.Ecma335;

public class Stats
{
    private int _points;
    private int _shotsAttempted;
    private int _shotsMade;
    private int _threePointsAttempted;
    private int _threePointsMade;
    private int _rebounds;
    private int _turnovers;
    private int _minutes;
    private int _assists;
public Stats(int points, int shotsAttempted, int threePointsAttempted, int rebounds, int turnovers, int minutes, int assists, int shotsMade, int threePointsMade)
    {
        _points = points;
        _shotsAttempted = shotsAttempted;
        _shotsMade = shotsMade;
        _threePointsAttempted = threePointsAttempted;
        _rebounds = rebounds;
        _turnovers = turnovers;
        _minutes = minutes;
        _assists = assists;
        _threePointsMade = threePointsMade;
    }
    public Stats()
    {
        _points = 0;
        _shotsAttempted = 0;
        _threePointsAttempted = 0;
        _rebounds = 0;
        _turnovers = 0;
        _minutes = 0;
        _assists = 0;
        _shotsMade = 0;
        _threePointsMade = 0;
    }
public int Points
{
    get{ return _points;}
    set{_points = value;}
}
public int ShotsAttempted
{
    get{return _shotsAttempted;}
    set{_shotsAttempted = value;}
}
public int ShotsMade
{
    get{ return _shotsMade;}
    set {_shotsMade = value;}
}
public int ThreePointsAttempted
{
    get{return _threePointsAttempted;}
    set{_threePointsAttempted = value;}
}
public int ThreePointsMade
{
    get{return _threePointsMade;}
    set{_threePointsMade = value;}
}
public int Rebounds
{
    get{return _rebounds;}
    set{_rebounds = value;}
}
public int Turnovers
{
    get{return _turnovers;}
    set{_turnovers = value;}
}
public int Minutes
{
    get{return _minutes;}
    set{_minutes = value;}
}
public int Assists
{
    get{return _assists;}
    set{_assists = value;}
}
public void GetAllStats()
    {
        Console.WriteLine("Enter player Stats");
        Console.WriteLine("");


        Console.Write("Points: ");
        Points = Int32.Parse(Console.ReadLine());

        Console.Write("Shots Attempted: ");
        ShotsAttempted = Int32.Parse(Console.ReadLine());

        Console.Write("Shots Made: ");
        ShotsMade = Int32.Parse(Console.ReadLine());

        Console.Write("Three Points Attempted: ");
        ThreePointsAttempted = Int32.Parse(Console.ReadLine());

        Console.Write("Three Points Made: ");
        ThreePointsMade = Int32.Parse(Console.ReadLine());

        Console.Write("Rebounds: ");
        Rebounds = Int32.Parse(Console.ReadLine());

        Console.Write("Turnovers: ");
        Turnovers = Int32.Parse(Console.ReadLine());

        Console.Write("Minutes Played: ");
        Minutes = Int32.Parse(Console.ReadLine());

        Console.Write("Assists: ");
        Assists = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Done");
    }

// Performance metrics
public double GetShotPerc()
    {
        return (double)_shotsMade / _shotsAttempted * 100;
    }
public double ThreePointPerc()
    {
        return (double)_threePointsMade / _threePointsAttempted * 100;
    }

public double AssistToTurnoverRatio()
{
    return (double)Assists / Turnovers;
}

// Impact metrics

public double PointsPerMinute()
{
    return Points / Minutes;
}

public double EffeciencyRating()
{
    return Points + Rebounds + Assists - Turnovers;
}
public void DisplayStats()
    {
        Console.WriteLine("Player Stats");
        Console.WriteLine($"{Points}");
        Console.WriteLine($"FG {ShotsMade} / {ShotsAttempted}");
        Console.WriteLine($"{ThreePointsMade} / {ThreePointsAttempted}");
        Console.WriteLine($"Rebounds: {Rebounds}");
        Console.WriteLine($"Assists: {Assists}");
        Console.WriteLine($"Turnover: {Turnovers}");
        Console.WriteLine($"Minutes: {Minutes}");
        Console.WriteLine();
        Console.WriteLine();
    }
}