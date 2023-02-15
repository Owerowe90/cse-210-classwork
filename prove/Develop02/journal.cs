using System;

namespace Owen_Journal
{
    public class Journal
    {
        List<Entry> entries = new List<Entry>();
        List<String> prompts = new List<String>();
        

// compiling entire entry (prompt, response, date)
        public void add_entry()
        {
            Entry new_entry = new Entry();
            Random rnd = new Random();
            int rnd_num = (rnd.Next(5));
            new_entry.response(prompts[rnd_num]);
            this.entries.Add(new_entry);
        }


// prompt list 
        public void load_prompts()
        {
            prompts.Add("Favorite food you ate today?");
            prompts.Add("Did you see anything funny today?");
            prompts.Add("What was the most boring part of your day?");
            prompts.Add("Who did you serve today?");
            prompts.Add("Did you read a book today?");
        }

// print journal
        public void print_journal()
        {
            foreach(Entry entry in this.entries)
            {
                entry.view();
            }
        }

// save journal
    public void get_journal(string file_name)
    {
        List<String> lines = new List<String>();
        foreach(Entry entry in this.entries)
            {
                string line = entry.save_entry();
                lines.Add(line);
            }
        save(lines, file_name);
    }

    private void save(List<String> lines, string file_name)
        {
            System.IO.File.WriteAllLines(file_name, lines);
        }

    public void replace_list(string[] lines)
    {
        entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            string prompt = parts[0];
            string entry = parts[1];
            string date = parts[2];

            Entry replace = new Entry();
            replace.prompt = prompt;
            replace.entry = entry;
            replace.date = date;

            entries.Add(replace);        
        }
    }
    }
}