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

    public void SetExpYrs(int years)
    {
        _expYrs = years;
    }

    public int GetExpYrs()
    {
        return _expYrs;
    }

    public void SetAccolades(string accolades)
    {
        _accolades = accolades;
    }

    public string GetAccolades()
    {
        return _accolades;
    }

    public void GetCoachInfo()
    {
        Console.WriteLine("Adding Coach");
        Console.WriteLine();
        Console.Write("first name ->");
        SetFName(Console.ReadLine());

        Console.Write("last name ->");
        SetLname(Console.ReadLine());

        Console.Write("Years of Experience: ");
        SetExpYrs(int.Parse(Console.ReadLine()));

        Console.WriteLine("---Coach Added---");
        Console.Write("Hit Enter to continue");
        Console.ReadLine();

    }

    public string BasicCoachInfo()
    {
        return $"{GetFName()} {GetLname()} Exp. {GetExpYrs()} ";
    }

    public override void Displayinfo()
    {
        Console.WriteLine($"{BasicCoachInfo()}");
        Console.WriteLine($"Exp {GetExpYrs()}");
        Console.WriteLine($"Accolades{GetAccolades()}");
    }




}