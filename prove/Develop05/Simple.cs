public class Simple: Goal
{
    private int _pointValue;

    public Simple(string name, string descript, int pointValue): base(name, descript)
    {
        _pointValue = pointValue;
    }

    public Simple() : base()
    {
    }

    public override int ProgressedGoal()
    {
        int pointReturn = 0;
        if (!IsComplete())
        {
            pointReturn = _pointValue;
        }
        SetAsComplete();
        return pointReturn;
    }

    public override string GetSaveString()
    {
        return $"simple||{GetName()}||{GetDescription()}||{_pointValue}||{IsComplete()}";
    }

    public override void LoadInfo(string[] info)
    {
        SetName(info[1]);
        SetDescription(info[2]);
        _pointValue = int.Parse(info[3]);
        SetCompletion(info[4] == "True");
    }
}