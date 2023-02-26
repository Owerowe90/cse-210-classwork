    namespace MindfulnessApp
    {
  public class Activity
    {
        protected int duration;

        public virtual void RunActivity()
        {
            Console.WriteLine("Running Activity");
        }
        public virtual void SetDuration()
        {
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
        }

    }
    }