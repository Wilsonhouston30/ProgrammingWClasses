public class ShortTermGoal :Goal
{
    private int _timesCompleted;

    public ShortTermGoal(string name, string description, int value,int timesCompleted) : base( name, description,value )
    {
        _timesCompleted = 0;
        value = 5;

    }

    public override void Record()
    {
        _timesCompleted++;
        SetCompleted();
        Console.WriteLine("Short term goal completed");

    }
}