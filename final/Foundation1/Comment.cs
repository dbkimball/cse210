public class Comment{

    private string _comment;

    private string _userName;

    public Comment(string userName,  string comment)
    {
        _userName = userName;
        _comment = comment;
    }

    public void GetCommentInfo()
    {
        Console.WriteLine($"  UserName: {_userName} - {_comment}");
    }
}