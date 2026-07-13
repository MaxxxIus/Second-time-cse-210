public class Video
{
    private string _title;
    private string _author;
    //in seconds
    private int _length;
    private List<Comment> _comments;

    public Video(string tit, string auth, int len)
    {
        _title = tit;
        _author = auth;
        _length = len;
    }

    public void AddComments(List<Comment> comm)
    {
        _comments = comm;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} Seconds");
        Console.WriteLine($"Number of Comments: {_comments.Count()}");
        Console.WriteLine($"Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }
}