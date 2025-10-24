public class Goal
{
 private string _name;
 private string _description;
 private int _value;

 private bool _completed;

 public Goal(string name, string description)
 {
    _name = name;
    _description = description;
    _value = 0;
    _completed = false;
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
    return _value;
 }
 public virtual int Multiplier()
 {
    return _value * 1;
 }

 public void Display()
 {
    Console.WriteLine($"{_name}");
 }

}