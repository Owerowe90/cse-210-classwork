namespace MindfulnessApp
{
class Breathing : Activity {
    // Start the breathing activity
    public override void RunActivity() {
        Console.WriteLine("Starting Breathing Activity...");
        // Set up the countdown
        Console.Write("Get ready to start in ");
        for (int i = 3; i >= 1; i--) {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");
        // Perform deep breathing for the specified duration
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Hold...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(3000);
        }
        Console.Clear();
        Console.WriteLine("Thank you for completing the activity! :)");
        System.Threading.Thread.Sleep(2000);
    }
}
}