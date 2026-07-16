public class Outdoor: Event
{
    private string _weather;

    public Outdoor(string title, Address addre, string date, string time, string descript, string weather): base(title, addre, date, time, descript)
    {
        _weather = weather;
    }

    public void DisplayShortDetail()
    {
        Console.WriteLine("Outdoor Gathering");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine("Outdoor Gathering");
        DisplayStandardDetails();
        Console.WriteLine(_weather);
    }
}