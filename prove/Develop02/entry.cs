using System.IO; 

namespace Owen_Journal
{
    class Entry
    {
        public string prompt;
        public string entry;
        public string date;

        public void response(string input_prompt)
        {
            Console.WriteLine(input_prompt);
            this.prompt = input_prompt;
            this.entry = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            this.date = theCurrentTime.ToShortDateString();

        }

        public void view()
        {
            Console.WriteLine($"{this.prompt} - {this.entry} - {this.date}");
        }

        public string save_entry()
        {
            string line = $"{this.prompt} - {this.entry} - {this.date}";
            return line;
        }
        
    }
}