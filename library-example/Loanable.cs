public class Loanable
{
    private bool _isCheckedIn = true;
    private string available = "pending request...";

    public void CheckOut()
    {
        _isCheckedIn = false;
        available = "It is checked out.";
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
        available = "It is available!";
    }

    public virtual void Display()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Available = {_isCheckedIn}");
            Console.WriteLine(available);
        }
}