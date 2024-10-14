using System.Net.WebSockets;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;

    private List <Comment> _comments = new List<Comment>();

    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
     public int GetLength()
    {
        return _length;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
      public void SetAuthor(string author)
    {
        _author = author;
    }
      public void SetLength(int length)
    {
        _length = length;
    }

   
  
  
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void GetCommentCount()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
    }
    public void DisplayComments()
    {
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}