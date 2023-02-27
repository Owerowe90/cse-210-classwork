    namespace MindfulnessApp
    {
  public class Activity
    {
        protected int duration;
        protected string[] spin = {"|", "/", "-", "|", "/", "-", "|"};
        protected string activity;
        protected string desc;
        public virtual void RunActivity()
        {
            Console.WriteLine("Running Activity");
        }

        public virtual void spinner()
        {
            foreach (string i in spin)
            {
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write($"\b");
            }
        }
        public virtual void Start()
        {
            Console.Write("Starting in ");
            for (int i = 3; i >= 1; i--) {
                Console.Write(i + "...");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("GO!");
        }

        public virtual void WhichAct(string activity, string desc)
        {
            Console.WriteLine($"Starting {activity} activity");
            Console.Write("");
            Thread.Sleep(1000);
            Console.WriteLine(desc);
            Thread.Sleep(1000);
        }

        public virtual void SetDuration()
        {
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
        }

    }
    }