public class WritingAssignemt : Assignment 
{
    private string _title;
    
    public WritingAssignemt(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}