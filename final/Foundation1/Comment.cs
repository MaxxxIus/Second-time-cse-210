public class Comment
{
    private string _author;
    private string _text;

    public Comment(string auth, string tex)
    {
        _author = auth;
        _text = tex;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine(_text);
    }
}