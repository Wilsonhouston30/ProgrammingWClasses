public class Word
{

    private string word; 

    private bool hidden;

     public bool IsHidden => hidden;


    public Word(string Word)
    {
        word = Word;
        hidden = false;
    }

    public string GetWord()
    {
        return hidden ? new string ('_', word.Length) : word;
    }
    public bool HideWord()
    {
        if (!hidden)
        {
            hidden = true;
            return hidden;
        }
        return false;
    }
}