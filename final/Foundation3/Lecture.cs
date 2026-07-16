public class Lecture: Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, Address address, string date, string time, string speaker, int cap, string descript ): base(title, address, date, time, descript)
    {
        _speaker = speaker;
        _capacity = cap;
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine("Lecture");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("Lecture");
        DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}