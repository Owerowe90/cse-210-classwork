using System;

namespace Owen_Journal
{

class Program
{
    static void Main()
    {
        Journal my_Journal = new Journal();
        
        // loading the list full of prompts
        my_Journal.load_prompts();

        // creates an entire entry

        bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(my_Journal);

            }}

        static bool MainMenu(Journal my_Journal)
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
                    my_Journal.add_entry();
                    
                    return true;

                // view
                case "2":
                    // Console.WriteLine("You put 2.");
                    my_Journal.print_journal();
                    return true;

                // save
                case "3":
                    Console.WriteLine("What would you like to name the file?");
                    string file_name = Console.ReadLine();
                    my_Journal.get_journal(file_name);
                    return true;

                // load
                case "4":
                    // Console.WriteLine("You put 4.");
                    Console.WriteLine("What Journal file would you like to access?");


                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    my_Journal.replace_list(lines);

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