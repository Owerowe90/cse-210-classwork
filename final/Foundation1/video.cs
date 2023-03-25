using System;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public int NumComments()
    {
        return comments.Count;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {NumComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment c in comments)
        {
            Console.WriteLine($"- {c.Name}: {c.Text}");
        }
        Console.WriteLine();
    }
}