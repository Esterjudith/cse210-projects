public class Comment 
{
    private string _name;
    private string _commentText;

    public Comment(string name, string comment) 
    {
        _name = name;
        _commentText = comment;
    }
   
    
    public void DisplayComment ()
    {
        Console.WriteLine($"{_commentText} - ({_name})");
    } 
}