namespace Dev03
{

    public class Program
    {
        static void Main() {
            Verse new_verse = new Verse();
            StorageScrip new_storage = new StorageScrip();
            Word word_word = new Word();

            Dictionary<string,string> verse_dict = new_verse.GetVerse();

            new_storage.full_verse(verse_dict);


            // foreach(string i in split_array){
            //     Console.WriteLine(i);
            word_word.GetVerse(new_storage.stringsplit_arr);
            word_word.GetReference(new_storage.chap);
            string input;
            do
            {
                Console.WriteLine("Press enter to hide a word, or type 'quit' to exit:");
                input = Console.ReadLine();
                if (input == "")
                {
                    word_word.hidden_verse();
            
                } 
            }
            while (input != "quit");
        }    
    }
}