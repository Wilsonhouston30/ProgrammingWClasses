public class CheckListGoal :Goal
{
    private int _timesCompleted;

    public CheckListGoal(string name, string description, int value,int timesCompleted) : base( name, description,value )
    {
        _timesCompleted = 0;
        value = 5;

    }

    public override void Record()
    {
        _timesCompleted++;
        SetCompleted();
        Console.WriteLine("Checklist goal completed");

    }
}