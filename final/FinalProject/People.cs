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

    public void SetFName(string fname)
    {
        _fName = fname;
    }

    public string GetFName()
    {
        return _fName;    
    }

    public void SetLname(string lname)
    {
        _lName = lname;
    }
    public string GetLname()
    {
        return _lName;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }


    public virtual void  Displayinfo()
    {
        Console.WriteLine($"Name {GetFName()} {GetLname()}");
    }
}