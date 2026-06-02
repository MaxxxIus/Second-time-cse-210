public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textBook, string problems) : 
        base(name, topic)
    {
        _textbookSection = textBook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string list = "Section " + _textbookSection + " Problems "+ _problems; 
        return list;
    }
}