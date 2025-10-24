public class CheckListGoal :Goal
{
    private int _timesCompleted;

    public CheckListGoal(string name, string description, int value, int timesCompleted) : base(name, description,value)
    {
        _timesCompleted = timesCompleted;
    }

    public override int GetPoints()
    {
        return _value;
    }
}