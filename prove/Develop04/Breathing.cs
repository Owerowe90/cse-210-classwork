namespace MindfulnessApp
{
class Breathing : Activity {
    // Start the breathing activity
    public override void RunActivity() {
        Console.WriteLine("Starting Breathing Activity...");
        spinner();
        // Thread.Sleep(2000)
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        spinner();
        // Thread.Sleep(3000);
        Console.Write("Get ready to start in ");
        for (int i = 3; i >= 1; i--) {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");
        spinner();
        Console.Clear();
        // Perform deep breathing for the specified duration
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            spinner();
            // System.Threading.Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("Hold...");
            spinner();
            // System.Threading.Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("Breathe out...");
            spinner();
            // System.Threading.Thread.Sleep(3000);
            Console.WriteLine("");
        }
        Console.Clear();
        Console.WriteLine("Thank you for completing the Breathing Activity! :)");
        spinner();
        // Thread.Sleep(2000);
    }
}
}