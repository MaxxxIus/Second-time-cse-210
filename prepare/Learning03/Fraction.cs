public class Fraction
{
    private int _AMBtopNum;
    private int _AMBbottomNum;

    //COnstructors
    public Fraction()
    {
        _AMBtopNum = 1;
        _AMBbottomNum = 1;
    }

    public Fraction(int AMBwholeNum)
    {
        _AMBtopNum = AMBwholeNum;
        _AMBbottomNum = 1;
    }

    public Fraction(int AMBtopNum, int AMBbottomNum)
    {
        _AMBtopNum = AMBtopNum;
        _AMBbottomNum = AMBbottomNum;
    }

    //top get and set
    public void SetTop(int AMBtop)
    {
        _AMBtopNum = AMBtop;
    }

    public int GetTop()
    {
        return _AMBtopNum;
    }

    //bottom set and get
    public void SetBottom(int AMBbottom)
    {
        _AMBbottomNum = AMBbottom;
    }

    public int GetBottom()
    {
        return _AMBbottomNum;
    }

    //fraction retreival
    public string GetFractionString()
    {
        string AMBfraction = $"{_AMBtopNum}/{_AMBbottomNum}";
        return AMBfraction;
    }

    public double GetDecimalValue()
    {
        double AMBdouble = (double) _AMBtopNum / _AMBbottomNum;
        return AMBdouble;
    }

}