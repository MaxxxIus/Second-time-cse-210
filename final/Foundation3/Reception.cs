public class Reception: Event
{
    private string _email;

    public Reception(string title, Address addre, string date, string time, string descript, string registry): base(title, addre, date, time, descript)
    {
        _email = registry;
    }

    public void DisplayShortDetail()
    {
        Console.WriteLine("Reception");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine("Reception");
        DisplayStandardDetails();
        Console.WriteLine($"To register, please use the following email to reach out: {_email}");
    }
}