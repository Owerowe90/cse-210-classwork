using System;

class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            
            Console.Clear();

            Console.WriteLine("Welcome! Glad you chose to workout today!");
            Thread.Sleep(2000);
            Console.WriteLine("Your session will begin soon.");

            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))) {  
                    Console.BackgroundColor = color;  
                    Console.Clear();
                    Thread.Sleep(75);
            } 

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // run
            Console.WriteLine("First Activity: Running");
            Thread.Sleep(1500);

            string act_run = "Run";

            Console.WriteLine("What was the distance? ");
            int dist_run = int.Parse(Console.ReadLine());

            Console.WriteLine("How much time did it take to compute (minutes)? ");
            int time_run = int.Parse(Console.ReadLine());  

            Console.Clear();
            
            // Bike
            Console.WriteLine("First Activity: Cycling");
            Thread.Sleep(1500);

            string act_bike = "Run";
            Console.WriteLine("What was the distance? ");
            int dist_bike = int.Parse(Console.ReadLine());

            Console.WriteLine("How much time did it take to compute (minutes)? ");
            int time_bike = int.Parse(Console.ReadLine());  

            Console.Clear();

            // swim

            Console.WriteLine("First Activity: Swimming");
            Thread.Sleep(1500);

            string act_swimn = "Swim";

            Console.WriteLine("How many laps did you complete? ");
            int lap_swim = int.Parse(Console.ReadLine());

            int length_pool = 50;

            Console.WriteLine("How much time did it take to compute (minutes)? ");
            int time_swim = int.Parse(Console.ReadLine()); 

            Console.Clear();

            activities.Add(new RunningActivity(act_run, dist_run, time_run));
            activities.Add(new CyclingActivity(act_bike, dist_bike, time_bike));
            activities.Add(new SwimActivity(act_swimn, lap_swim, length_pool, time_swim));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }