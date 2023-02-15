namespace Journal_Space
{

public class Journal
{
    public string prompt;

    public List<string> entry;
    
    public void Display()
    {
        Console.WriteLine(prompt);
        foreach(string answer in entry)
        {
            Console.WriteLine(answer);
        }

    }
    public void add_new_entry(string new_entry)
    {
        entry.Add(new_entry);
    }
}
}