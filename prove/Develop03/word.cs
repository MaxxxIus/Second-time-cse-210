public class Word
{
    private string _AMBword;
    private bool _AMBhiden;

    public Word(string word)
    {
        _AMBword = word;
        _AMBhiden = false;
    }

    public void SetHidden()
    {
        _AMBhiden = true;
    }

    public bool GetHidden()
    {
        return _AMBhiden;
    }

    public string GetString()
    {
        if (_AMBhiden == false)
        {
            return _AMBword;
        } else
        {
            string AMBblank = "";
            foreach (char letter in _AMBword)
            {
                    AMBblank = AMBblank + "_";
            }
            return AMBblank;
        }
    }
}