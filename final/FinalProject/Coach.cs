public class Coach : People
{
    private int _expYrs;
    private string _accolades;

    public Coach(int expYrs, string accolades, string fName, string lName, string phoneNumber) : base(fName,lName,phoneNumber)
    {
        _expYrs = expYrs;
        _accolades = accolades;
    }


    public Coach() : base("NA", "N/A", "N/A")
    {
        _expYrs = 0;
        _accolades = "N/A";
    }

    public int ExpYrs
    {
        get{return _expYrs;}
        set{_expYrs = value;}
    }

    public string Accolades
    {
        get{return _accolades;}
        set{_accolades = value;}
    }

    public void GetCoachInfo()
    {
        Console.WriteLine("Adding Coach");
        Console.WriteLine();
        Console.Write("first name ->");
        FName = Console.ReadLine();

        Console.Write("last name ->");
        LName = Console.ReadLine();

        Console.Write("Years of Experience: ");
        ExpYrs = Int32.Parse(Console.ReadLine());

        Console.WriteLine("---Coach Added---");
        Console.Write("Hit Enter to continue");
        Console.ReadLine();

    }

    public string BasicCoachInfo()
    {
        return $"{FName} {LName} Exp. {ExpYrs} ";
    }

    public override void Displayinfo()
    {
        Console.WriteLine($"{BasicCoachInfo()}");
        Console.WriteLine($"Exp {ExpYrs}");
        Console.WriteLine($"Accolades{Accolades}");
    }
}