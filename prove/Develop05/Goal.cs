public abstract class Goal
{
    private string _name;
    private string _description;
    private bool _complete;

    //use for creating object from loaded txt string
    public Goal()
    {
    }

    //use for creating a fresh goal object
    public Goal(string name, string descript)
    {
        _name = name;
        _description = descript;
        _complete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string descript)
    {
        _description = descript;
    }

    public void SetCompletion(bool status)
    {
        _complete = status;
    }
    public bool IsComplete()
    {
        return _complete;
    }

    public void SetAsComplete()
    {
        _complete = true;
    }

        public virtual string GetGoalString()
    {
        string xMark = " ";
        if(IsComplete() == true)
        {
            xMark = "X";
        }
        return $"[{xMark}] {GetName()} ({GetDescription()})";
    }
    public abstract string GetSaveString();
    public abstract void LoadInfo(string[] info);
    public abstract int ProgressedGoal();
}