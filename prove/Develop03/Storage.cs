namespace Dev03
{
public class StorageScrip
{
    Verse verse_dictionary = new Verse();
    public string chap;
    public string[] verse_list;
    public List<string> stringsplit_arr = new List<string>();

    public void full_verse (Dictionary <string, string> dictionary)
    {
        foreach (string key in dictionary.Keys)
        {
        // do something with key
            chap = key;
        }
        
        // iterate over C# Dictionary Keys only
        foreach (string value in dictionary.Values)
        {
        // do something with value
            string verse = value;
            verse_list = new string[]{verse};
        }

        split_verse(this.verse_list);
    }

    private void split_verse(string[] string_arr)
    {
        foreach(string word in string_arr) {
            string[] split_words= word.Split(' ');
            foreach (string split_word in split_words) {
                stringsplit_arr.Add(split_word);
            }
        }
    }

}
}