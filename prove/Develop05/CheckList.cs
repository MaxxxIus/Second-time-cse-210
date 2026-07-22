public class CheckList: Goal
{
    private int _pointValue;
    private int _bonusPoints;
    private int _endGoal;
    private int _currentProgress;

    public CheckList(): base(){}
    
    public CheckList(string name, string descript, int value, int bonus, int end): base(name, descript)
    {
        _pointValue = value;
        _bonusPoints = bonus;
        _endGoal = end;
        _currentProgress = 0;
    }

    public override int ProgressedGoal()
    {
        int pointReturn = 0;
        if (!IsComplete())
        {
            pointReturn = _pointValue;
            _currentProgress += 1;
            if (_currentProgress == _endGoal)
            {
                pointReturn += _bonusPoints;
                SetAsComplete();
            }
        }
        return pointReturn;
    }

    public override string GetGoalString()
    {
        return base.GetGoalString() + $" {_currentProgress}/{_endGoal}";
    }

    public override string GetSaveString()
    {
        return $"check||{GetName()}||{GetDescription()}||{IsComplete()}||{_pointValue}||{_bonusPoints}||{_currentProgress}||{_endGoal}";
    }

    public override void LoadInfo(string[] info)
    {
        SetName(info[1]);
        SetDescription(info[2]);
        SetCompletion(info[3] == "True");
        _pointValue = int.Parse(info[4]);
        _bonusPoints = int.Parse(info[5]);
        _currentProgress = int.Parse(info[6]);
        _endGoal = int.Parse(info[7]);
    }
}