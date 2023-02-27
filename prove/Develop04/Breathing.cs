namespace MindfulnessApp
{
class Breathing : Activity {
    // Start the breathing activity
    string breath = "Breathing";
    string desc_breath = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public override void RunActivity() {
        WhichAct(breath, desc_breath);
        spinner();
        Start();
        Thread.Sleep(1000);
        Console.Clear();
        // Perform deep breathing for the specified duration
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            spinner();
            
            Console.WriteLine("");
            Console.WriteLine("Hold...");
            spinner();
            
            Console.WriteLine("");
            Console.WriteLine("Breathe out...");
            spinner();
            
            Console.WriteLine("");
        }
        Console.Clear();
        Console.WriteLine("Thank you for completing the Breathing Activity! :)");
        spinner();
    }
}
}