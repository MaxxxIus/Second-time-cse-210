public abstract class Activity
{
    private string _type;
    private string _date;
    private double _length;

    public Activity(string type, string date, double length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string DisplaySummary()
    {
        string summary = $"{_date} {_type} ({_length} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        return summary;
    }
}