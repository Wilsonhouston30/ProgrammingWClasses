public class Coach : People
{
    private int _expYrs;
    private string _accolades;

    public Coach(int expYrs, string accolades, string fName, string lName, string phoneNumber) : base(fName,lName,phoneNumber)
    {
        _expYrs = expYrs;
        _accolades = accolades;
    }
    
}