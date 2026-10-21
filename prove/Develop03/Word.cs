class Word
{
    private string _word;

    private string _returnString;

    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Display()
    {
        Console.Write($"{GetWordString}");
    }
    
    public string GetWordString()
    {
        return _returnString = "";
        if (_hidden)
        {
            for(int i = 0l i < _word.Length; i++)
            {
                _returnString += '_';
            } 
        }
        else
        {
            _returnString = _word;
        }
    }
}