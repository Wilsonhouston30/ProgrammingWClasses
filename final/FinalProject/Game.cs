using System.Security.Cryptography.X509Certificates;

public class Game
{
    private string _opponent;
    private string _date;
    private bool _winLoss;


    public Game(string opponent, string date, bool winLoss)
    {
        _opponent = opponent;
        _date = date;
        _winLoss = winLoss;
    }

    public Game()
    {
        _opponent = "N/A";
        _winLoss = false;
    }
    public string Opponent
    {
        get{return _opponent;}
        set{_opponent = value;}
    }
    public string GetDate()
    {
        return _date;
    }

    public void SetDate()
    {
        Console.Write("Enter the date (mm/dd/yyyy): ");
        _date = Console.ReadLine();
    }


}