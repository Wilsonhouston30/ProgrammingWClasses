using System.Reflection.Metadata.Ecma335;

public class Stats
{
    private int _point;
    private int _attempt;
    private int _missedAttempt;
    private int _threepoint;
    private int _threepointAttempted;
    private int _missedThreePointAttempted;
    private int _rebound;
    private int _turnover;
    private int _minute;
    private int _assist;


    public Stats(int point, int attempt, int threepoint, int threepointAttempted, int rebounds, int turnover, int minute, int assist, int missedAttempt, int missedThreePointAttempted)
    {
        _point = point;
        _attempt = attempt;
        _missedAttempt = missedAttempt;
        _threepoint = threepoint;
        _threepointAttempted = threepointAttempted;
        _missedThreePointAttempted = missedThreePointAttempted;
        _rebound = rebounds;
        _turnover = turnover;
        _minute = minute;
        _assist = assist;
        _missedAttempt = missedAttempt;
        _missedThreePointAttempted = missedThreePointAttempted;
    }
    public Stats()
    {
        _point = 0;
        _attempt = 0;
        _threepoint = 0;
        _threepointAttempted = 0;
        _rebound = 0;
        _turnover = 0;
        _minute = 0;
        _assist = 0;
        _missedAttempt = 0;
        _missedThreePointAttempted = 0;
    }



    public void SetPoint(int point)
    {
        _point = point;
    }

    public int GetPoint()
    {
        return _point;
    }
    public void SetAttempt(int attempt)
    {
        _attempt = attempt;
    }

    public int GetAttempt()
    {
        return _attempt;
    }

    public void SetMissedAttempt(int missedAttempt)
    {
        _missedAttempt = missedAttempt;
    }

    public int GetMissedAttempt()
    {
        return _missedAttempt;
    }

    public void SetThreePointer(int threepoint)
    {
        _threepoint = threepoint;
    }

    public int GetThreePointer()
    {
        return _threepoint;
    }
    public void SetThreePointAttempted(int threepointAttempted)
    {
        _threepointAttempted = threepointAttempted;
    }

    public int GetThreePointAttempted()
    {
        return _threepointAttempted;
    }

    public void SetMissedThreePointAttempted(int missedThreePointAttempted)
    {
        _missedThreePointAttempted = missedThreePointAttempted;
    }

    public int GetMissedThreePointAttempted()
    {
        return _missedThreePointAttempted;
    }


    public void SetRebound(int rebounds)
    {
        _rebound = rebounds;
    }

    public int GetRebound()
    {
        return _rebound;
    }
    public void SetTurnover(int turnover)
    {
        _turnover = turnover;
    }

    public int GetTurnover()
    {
        return _turnover;
    }
    public void SetMinute(int minute)
    {
        _minute = minute;
    }

    public int GetMinute()
    {
        return _minute;
    }
    public void SetAssist(int assist)
    {
        _assist = assist;
    }

    public int GetAssist()
    {
        return _assist;
    }

    public void GetAllStats()
    {
        Console.WriteLine("Enter player Stats");
        Console.WriteLine("");


        Console.WriteLine("Point(s): ");
        SetPoint(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Attempt(s): ");
        SetAttempt(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Missed Attempt(s): ");
        SetMissedAttempt(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Three Pointer(s): ");
        SetThreePointer(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Three Pointer Attempted: ");
        SetThreePointAttempted(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Three Pointers Missed");
        SetMissedThreePointAttempted(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Rebound(s): ");
        SetRebound(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Turnover(s): ");
        SetTurnover(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Minute(s): ");
        SetMinute(Int32.Parse(Console.ReadLine()));


        Console.WriteLine("Assist(s)");
        SetAssist(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Stats Added");
    }

    public double GetShotPerc()
    {
        int totalMadeshots = GetAttempt() - GetMissedAttempt();
        return (double) totalMadeshots / GetAttempt() * 100;
    }

    public double ThreePointPerc()
    {
        int totalMadeThrees = GetThreePointAttempted() - GetMissedThreePointAttempted();
        return (double)totalMadeThrees / GetMissedThreePointAttempted() * 100;
    }

    public void DisplayStats()
    {
        Console.WriteLine("Player Stats");
        Console.WriteLine($"{GetPoint()}");
        Console.WriteLine($"FG {GetAttempt() - GetMissedAttempt()} / {GetAttempt()} %{GetShotPerc()}");
        Console.WriteLine($"Three Point: {GetThreePointAttempted() - GetMissedThreePointAttempted()}/ {GetThreePointAttempted()} %{ThreePointPerc()}");
        Console.WriteLine($"Rebounds: {GetRebound()}");
        Console.WriteLine($"Assists: {GetAssist()}");
        Console.WriteLine($"Turnover: {GetTurnover()}");
        Console.WriteLine($"Minutes: {GetMinute()}");
        Console.WriteLine();
        Console.WriteLine();

        
    }






}