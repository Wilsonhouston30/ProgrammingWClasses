public class Word
{
    private string _word;
    private string _hidden;

    public  Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public string Hideword()
    {
        return _hidden;
    }
}