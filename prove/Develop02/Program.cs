using System;

namespace Journal
{
class Program
{
    static void Main(string[] args)
    {
        List<Journal> _journalPrompt = new List<Journal>(); 
        Journal entry_1 = new Journal();
        entry_1.prompt = "Who was the most interesting person I interacted with today?";
        _journalPrompt.Add(entry_1);

        Journal entry_2 = new Journal();
        entry_2.prompt = "What was the best part of my day?";
        _journalPrompt.Add(entry_2);

        Journal entry_3 = new Journal();
        entry_3.prompt = "How did I see the hand of the Lord in my life today?";
        _journalPrompt.Add(entry_3);

        Journal entry_4 = new Journal();
        entry_4.prompt = "How did I see the hand of the Lord in my life today?";
        _journalPrompt.Add(entry_4);

        Journal entry_5 = new Journal();
        entry_5.prompt = "What was the strongest emotion I felt today?";
        _journalPrompt.Add(entry_5);

        Journal entry_6 = new Journal();
        entry_6.prompt = "If I had one thing I could do over today, what would it be?";
        _journalPrompt.Add(entry_6);

        bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(_journalPrompt);

            }}

        static bool MainMenu(List<Journal> _journalPrompt)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("(1) Entry");
            Console.WriteLine("(2) View");
            Console.WriteLine("(3) Save");
            Console.WriteLine("(4) Load");
            Console.WriteLine("(5) Exit");
            Console.Write("\r\nPlease Choose an option: ");
 

            switch (Console.ReadLine())
            {
                // entry
                case "1":
                Random rnd = new Random();

                    int rnd_num = (rnd.Next(5)); //returns random integers < 5
                    
                    string index = _journalPrompt[rnd_num].prompt;
                    Console.Write(index);
                    string entry = Console.ReadLine();
                    _journalPrompt[rnd_num].entry.Add(entry);

                    // Console.WriteLine("You put 1.");
                    
                    return true;

                // view
                case "2":
                    // Console.WriteLine("You put 2.");
                    foreach (Journal j in _journalPrompt)
                            {
                                // This calls the Display method on each job
                                j.Display();
                            }
                    return true;

                // save
                case "3":
                    // Console.WriteLine("You put 3.");

                    return true;

                // load
                case "4":
                    // Console.WriteLine("You put 4.");

                    return true;

                // exit 
                case "5":
                    // Console.WriteLine("You put 5.");

                    return false;
                default:
                    return true;
            }
    }
    }
}