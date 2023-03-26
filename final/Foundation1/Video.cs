using System;

public class Video
{
    private string _title;

    private string _creator;

    private int _length;
    
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
    }
    public void Comment(string username, string comment)
    {
        Comment newComment = new Comment(username, comment);
        _comments.Add(newComment);
    }
    public void GetVideo()
    {   
        string format = "00";
        string seconds;
        int remainingSeconds = _length % 60;
        seconds = remainingSeconds.ToString(format);
        Console.WriteLine($"{_title} By: {_creator} -- {_length / 60}:{seconds}");
        foreach(Comment comment in _comments)
        {
            comment.GetVideo();
        }
        
        
    }
       
}



