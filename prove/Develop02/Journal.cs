using System.IO; 
public class Journal
{
    public List<Entry> _entrys = new List<Entry>();

    public Promt _promt = new Promt();
    public string name;


    public void newEntry()
    {
        Console.WriteLine();


        string promt = _promt.DisplayPromt();

        Console.WriteLine(promt);
        Console.Write("->  ");
        string userResponse = Console.ReadLine();

        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToShortDateString();


        Entry insertingEntry = new Entry(promt, userResponse, date);

        _entrys.Add(insertingEntry);
        Console.Clear();
        Console.WriteLine("Entry Added");
        
    }

    public void Display()
    {
        foreach(Entry entry in _entrys )
        {
            entry.DisplayEntry();
        }
    }

    public void SaveEntry()
    {
        Console.Write("Enter your Name (file name) -> ");
        string file = Console.ReadLine();
        string fileName =  file + ".txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entrys)
            {
                outputFile.WriteLine($"Promt: {entry._propmt}");
                outputFile.WriteLine($"Entry:{entry._repponse}");
                outputFile.WriteLine($"{entry._date}");
                outputFile.WriteLine("___________________________");
                outputFile.WriteLine("");
            }
        }
        Console.WriteLine($"Saved to '{file}' ");
    }

    public void loadFiles()
    {
        Console.WriteLine();
        Console.Write("Enter name -> ");
        string name = Console.ReadLine() + ".txt";
        
        string [] lines  = System.IO.File.ReadAllLines(name);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}