using System;

public class Comment
{
    private string _ownerComment;
    private string _textComment;

    public Comment(string ownerComment, string textComment)
    {
        _ownerComment = ownerComment;
        _textComment = textComment;
    }

    public string Display()
    {
        return $"{_ownerComment}: {_textComment}";
    }
}

