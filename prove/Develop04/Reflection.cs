namespace MindfulnessApp
{
class Reflection: Activity {
    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public override void RunActivity() {
        // inherited RunActivity will go here! 
        Console.WriteLine("Starting Reflection Activity...");
        Thread.Sleep(2000);
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(3000);
        Console.Write("Starting in ");
        for (int i = 3; i >= 1; i--) {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");

        // Select a random prompt
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            System.Threading.Thread.Sleep(1000);

            Console.Write("- ");
            string item = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Thank you for completing the Reflection Activity! :)");
        Thread.Sleep(2000);
    }
}
}