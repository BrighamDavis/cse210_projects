using System;

public class Comment
{
    public string _author;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"{_author} : {_comment}");
    }
}