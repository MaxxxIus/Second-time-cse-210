public class Scripture
{
    private Reference _AMBref;
    private List<Word> _AMBwords;

    public Scripture(string AMBref, string AMBpassage)
    {
        _AMBref = new Reference(AMBref);
        _AMBwords = new List<Word>();
        CreateWords(AMBpassage);

    }
    private void CreateWords(string AMBpassage)
    {
        string[] words = AMBpassage.Split(" ");
        foreach(string word in words)
        {
            Word currentWord = new Word(word);
            _AMBwords.Add(currentWord);
        }
    }
    public string GetPassage()
    {
        string AMBpassage = _AMBref.GetReference() + ";";
        foreach (Word word in _AMBwords)
        {
            AMBpassage = AMBpassage + " " + word.GetString();
        }
        return AMBpassage;
    }
    public void HideRandom()
    {
        Random randomGen = new Random();
        bool fin = false;
        while (fin != true)
        {
            int randomNum = randomGen.Next(0, _AMBwords.Count());
            if (_AMBwords[randomNum].GetHidden() != true)
            {
                _AMBwords[randomNum].SetHidden();
                fin = true;
            }
        }
    }
        public bool CheckHiddenAll()
    {
        bool allHidden = true;
        foreach(Word word in _AMBwords)
        {
            if (word.GetHidden() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}