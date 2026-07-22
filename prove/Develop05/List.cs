public class List: Goal
{
    private int _pointValue;

    public List(): base(){}

    public List(string name, string descript, int value): base(name, descript)
    {
        _pointValue = value;
    }

    public override int ProgressedGoal()
    {
        return _pointValue;
    }

    public override string GetSaveString()
    {
        return $"list||{GetName()}||{GetDescription()}||{_pointValue}";
    }

    public override void LoadInfo(string[] info)
    {
        SetName(info[1]);
        SetDescription(info[2]);
        _pointValue = int.Parse(info[3]);
        SetCompletion(false);
    }
}