public class Word
{
    private string _word;
    private bool _hidden;

    public  Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool Hidword()
    {
        return _hidden;
    }
}