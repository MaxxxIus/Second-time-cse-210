public class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment(string name, string topic, string title) :
        base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return _title + " by "+ _studentName;
    }
}