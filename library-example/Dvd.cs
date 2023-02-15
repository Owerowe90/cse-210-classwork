public class Dvd : Loanable
{
    private string _title;
    private int _amount;
    private string _genre;
    private static int _total;
    private static bool _displayedTotal = false;

    public Dvd(string title, int amount, string genre)
    {
        _title = title;
        _amount = amount;
        _genre = genre;
        _total += amount;
    }

    public void ShowDvdDeets()
    {
        Console.WriteLine($"{_title}: ${_amount}, {_genre}");
    }

    public static void DvdAmount()
    {   
        if (!_displayedTotal)
        {
            Console.WriteLine($"Total: ${_total}");
            _displayedTotal = true;
        }
    }

}

