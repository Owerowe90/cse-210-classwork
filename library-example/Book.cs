public class Book : Loanable
{
    private string _isbin;
    private string _title;
    private string _upc;

    public Book(string title, string isbin, string upc)
    {
        _title = title;
        _isbin = isbin;
        _upc = upc;
    }

    public void ShowBookDeets()
    {
        Console.WriteLine($"{_title}: {_isbin}, {_upc}");
    }

    public override void Display(){
        base.Display();
        ShowBookDeets();
    }
}
