    namespace MindfulnessApp
    {
  public class Activity
    {
        protected int duration;
        protected string[] spin = {"|", "/", "-", "|", "/", "-", "|"};
        

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
        public virtual void SetDuration()
        {
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
        }

    }
    }