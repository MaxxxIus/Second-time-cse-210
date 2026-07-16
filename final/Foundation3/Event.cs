public class Event
{
    private string _title;
    private Address _address;
    private string _date;
    private string _time;
    private string _description;

    public Event(string title, Address address, string date, string time, string description)
    {
        _title = title;
        _address = address;
        _date = date;
        _time = time;
        _description = description;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Date & Time: {_date} at {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine("Description:");
        Console.WriteLine(_description);
    }

    public string GetTitle()
    {
        return _title;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetDescription()
    {
        return _description;
    }
}