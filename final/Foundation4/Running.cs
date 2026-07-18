public class Running: Activity
{
    private double _distance;

    public Running(string date, double length, double distance): base("Running", date, length)
    {
        _distance =distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / GetLength() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / _distance;
        return pace;
    }
}