namespace Journal 
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
            Console.WriteLine(entry);
        }

    }
}
}