using System;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLenght;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLenght)
    {
        _title = title;
        _author = author;
        _videoLenght = videoLenght;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        return _comments.Count();
    }

    public string DisplayVideo()
    {
        return $"{_title}, {_author}, Total seconds: {_videoLenght}";
    }

    public string DisplayComments()
    {
        string result = "";
        foreach (Comment comment in _comments)
        {
            result += comment.Display() + "\n";
        }
        return result;
    }
}