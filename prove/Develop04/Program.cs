namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App!");
                Console.WriteLine("Please choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");
                Console.WriteLine(" ");
                Thread.Sleep(1000);
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Breathing breathing_act = new Breathing();
                        breathing_act.SetDuration();
                        breathing_act.RunActivity();

                        break;
                    case "2":
                        Reflection reflection_act = new Reflection();
                        reflection_act.SetDuration();
                        reflection_act.RunActivity();
                        break;

                    case "3":
                        Listing listing_act = new Listing();
                        listing_act.SetDuration();
                        listing_act.RunActivity();
                        break;

                    case "4":
                        Console.WriteLine("Thanks for using the Mindfulness App!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                        
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}