namespace MindfulnessApp
{
class Listing : Activity
{
    public string[] prompts = { "What are some happy things that have happened to you?", 
                                "What are some people you appreciate?", 
                                "What are some of your strengths?", 
                                "What are some ways you have seen Gods hand in your life?", 
                                "Who do you look up to?", 
                                "What are ways you have served people?"};
    
    public override void RunActivity()
    {
        Console.WriteLine("Starting Listing Activity...");
        spinner();
        // Thread.Sleep(2000);
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        spinner();
        // Thread.Sleep(3000);
        Console.Write("Starting in ");
        for (int i = 3; i >= 1; i--) {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("You have " + duration + " seconds to list as many items as you can.");
        spinner();
        // Thread.Sleep(1000);
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine("Here is the prompt:");

        Thread.Sleep(2000);
        Console.WriteLine(prompt);

        Thread.Sleep(3000);
        Console.WriteLine("\n\nBegin listing items:");

        // Start timer and allow user to input items
        DateTime startTime = DateTime.Now;
        int itemCnt = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("- ");
            string item = Console.ReadLine();
            itemCnt++;
        }

        // Display number of items listed
        Console.Clear();
        Console.WriteLine($"You listed {itemCnt} items.");
        Console.WriteLine("Thank you for completing the Listing Activity! :)");
        spinner();
        // Thread.Sleep(2000);
    }
    }
    
}


