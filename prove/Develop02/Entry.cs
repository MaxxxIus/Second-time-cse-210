public class Entry
{
    public string _AMBdate;
    public string _AMBprompt;
    public string _AMBresponse;

    public void Display()
    {
        Console.WriteLine($"Date: {_AMBdate}");
        Console.WriteLine($"Prompt: {_AMBprompt}");
        Console.WriteLine($"Response: {_AMBresponse}");
    }

    public string ToTxTFormat()
    {
        string AMBtxt = $"{_AMBdate}<||>{_AMBprompt}<||>{_AMBresponse}";
        return AMBtxt;
    }
}