using System.Reflection.Metadata.Ecma335;

public class People
{
    private string _fName;
    private string _lName;
    private string _phoneNumber;

    public People(string fName, string lName, string phoneNumber)
    {
        _fName = fName;
        _lName = lName;
        _phoneNumber = phoneNumber;
    }

public string FName
{
    get{return _fName;}
    set{_fName = value;}
}
public string LName
{
    get{return _lName;}
    set{_lName = value;}
}
public string PhoneNumber
{
    get{return _phoneNumber;}
    set{_phoneNumber = value;}
}


    public virtual void  Displayinfo()
    {
        Console.WriteLine($"Name {FName} {LName}");
    }
    public virtual void DisplayAllInfo()
    {
        Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
}