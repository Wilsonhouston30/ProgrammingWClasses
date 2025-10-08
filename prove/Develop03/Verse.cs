public class Verse 
{
    private List<Word> words = new List<Word>();

    public Verse(string scripture)
    {
        foreach (var word in scripture.Split(' '))
        {
            words.Add(new Word (word));
        }
    }

    public string GetVerse()
    {
        return string.Join(" ",words.Select(w => w.GetWord()));
    }


}