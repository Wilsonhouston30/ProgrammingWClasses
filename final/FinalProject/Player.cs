public class Player : People
{
    private int _number;
    private string _position;
    private string _grade;
    private string _height;


    public Player(int number, string position, string grade,string height,string fName, string lName, string phoneNumber) : base(fName,lName,phoneNumber)
    {
        _number = number;
        _position = position;
        _grade = grade;
        _height = height;
    }
    
}