using System; 

public class Video 
{
    public string _title; 
    public string _creator; 
    public int _length; 

    public List<Comment> comments {get; set; } = new List<Comment>();


    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_title} - {_creator} ({_length} seconds)");
        Console.WriteLine($"Comments({comments.Count})");
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
        Console.WriteLine("");
    }
}
