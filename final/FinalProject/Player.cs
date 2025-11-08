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

    public string Number
    {
        get{return _number;}
        set{_number = value;}
    }

    public string Position
    {
        get{return _position;}
        set{_position = value;}
    }

    public string Grade
    {
        get{return _grade;}
        set{_grade = value;}
    }
    public string Height
    {
        get{return _height;}
        set{_height = value;}
    }
    public void GetAllPlayerInfo()
    {
        Console.WriteLine("Adding new player:");
        Console.WriteLine();
        Console.Write("first name ->");
        FName = Console.ReadLine();

        Console.Write("last name ->");
        LName = Console.ReadLine();

        Console.Write("Phone Number (N/A if none) ->");
        PhoneNumber = Console.ReadLine();

        Console.Write("jersey Number->");
        Number = Console.ReadLine();

        Console.Write("Position ->");
        Position = Console.ReadLine();

        Console.Write("Height ->");
        Height = Console.ReadLine();

        Console.Write("Grade ->");
        Grade = Console.ReadLine();

        Console.WriteLine("---Player Added---");
        Console.Write("Hit Enter to continue");
        Console.ReadLine();
    }

    public string BasicPlayerInfo()
    {
        return $"{FName} {LName}  #{Number}  {Position}";
    }
    public override void Displayinfo()
    {
        Console.WriteLine($"{BasicPlayerInfo()}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Grade: {Grade}");
    }
    


}