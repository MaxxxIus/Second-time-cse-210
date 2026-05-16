public class PromptGenerator
{
    public List<string> _AMBprompts = new List<string>();


    public void AddPrompt(string prompt)
    {
        _AMBprompts.Add(prompt);
    }

    public string GivePrompt()
    {
        Random AMBnumGen = new Random();
        int AMBlength = _AMBprompts.Count();
        int AMBprompt = AMBnumGen.Next(0, AMBlength);
        return _AMBprompts[AMBprompt];
    }
}