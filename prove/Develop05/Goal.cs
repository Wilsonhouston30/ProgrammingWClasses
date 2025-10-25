public class Goal
{
private string _name;
 private string _description;
 private int _points;

 private bool _completed = false;

 public Goal(string name, string description, int point)
 {
    _name = name;
    _description = description;
    _points = point;
    _completed = false;
 }

 public Goal()
 {

 }
 public string GetName()
 {
    return _name;
 }
 public void SetName(string name)
 {
    _name = name;
 }

 public string GetDescription()
 {
    return _description;
 }
 public void SetDescription(string description)
 {
    _description = description;
 }

 public virtual int GetPoints()
 {
    return 0;
 }


public void SetCompleted()
{
    _completed = true;
}

 public virtual int Multiplier()
 {
    return GetPoints() * 1;
 }

 public void Display()
 {
    Console.WriteLine($"Goal: {GetName()}, Description: {GetDescription()}     {GetPoints()}");
 }

 public virtual void Record()
 {
    _completed = true;
    Console.WriteLine(($"-> Goal: {GetName()} was completed. You've earned {GetPoints()}"));
 }

 public int SelectGoal()
 {
    Console.WriteLine("Select a goal");
    string [] selectGoal = ["Daily Check List", "Short Term Goal", "Long Term Goal" ]; 
    for (int i = 0; i< selectGoal.Length; i++)
    {
        Console.WriteLine($"{i+1}. {selectGoal[i]}");
    }

    int selection = int.Parse(Console.ReadLine());
    return selection;

 }

}