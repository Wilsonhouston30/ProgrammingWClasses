public class Entry
{
    public string _propmt;

    public string _repponse;

    public string _date;


    public Entry (string prompt, string response, string date)
    {
        _propmt = prompt;
        _repponse = response;
        _date = date;
    }


    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Promt: {_propmt}");
        Console.WriteLine($"Response: {_repponse} - {_date}");
        Console.WriteLine();
    }

}