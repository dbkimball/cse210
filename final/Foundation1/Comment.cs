using System;

public class Comment{

    private string _comment;

    private string _userName;

    public Comment(string userName,  string comment)
    {
        _userName = userName;
        _comment = comment;
    }

    public void GetVideo()
    {
        Console.WriteLine($"    {_userName}: {_comment}");
    }
}