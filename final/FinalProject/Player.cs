public class Player : People
{
    private string _number;
    private string _position;
    private string _grade;
    private string _height;


    public Player(string number, string position, string grade,string height,string fName, string lName, string phoneNumber) : base(fName,lName,phoneNumber)
    {
        _number = number;
        _position = position;
        _grade = grade;
        _height = height;
    }

    public Player() : base("NA", "N/A", "N/A")
    {
        _number = "N/A";
        _position = "N/A";
        _grade = "N/A";
        _height = "N/A";
    }

    public void SetNumber(string number)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;    
    }

    public void SetPosition(string position)
    {
        _position = position;
    }
    public string GetPosition()
    {
        return _position;
    }

    public void SetGrade(string grade)
    {
        _grade = grade;
    }

    public string GetGrade()
    {
        return _grade;
    }

    public void SetHeight(string height)
    {
        _height = height;
    }

    public string GetHeight()
    {
        return _height;
    }
    public void GetAllPlayerInfo()
    {
        Console.WriteLine("Adding new player:");
        Console.WriteLine();
        Console.Write("first name ->");
        SetFName(Console.ReadLine());

        Console.Write("last name ->");
        SetLname(Console.ReadLine());

        Console.Write("Phone Number (N/A if none) ->");
        SetPhoneNumber(Console.ReadLine());

        Console.Write("jersey Number->");
        SetNumber(Console.ReadLine());

        Console.Write("Position ->");
        SetPosition(Console.ReadLine());

        Console.Write("Height ->");
        SetHeight(Console.ReadLine());

        Console.Write("Grade ->");
        SetGrade(Console.ReadLine());

        Console.WriteLine("---PLAYER ADDED---");
        Console.Write("Hit Enter to continue");
        Console.ReadLine();
    }

    public string BasicPlayerInfo()
    {
        return $"{GetFName()} {GetLname()}  #{GetNumber()}  {GetPosition()}";
     
    }
    public override void Displayinfo()
    {
        Console.WriteLine($"{BasicPlayerInfo()}");
        Console.WriteLine($"Phone Number: {GetPhoneNumber()}");
        Console.WriteLine($"Height: {GetHeight()}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }
    


}