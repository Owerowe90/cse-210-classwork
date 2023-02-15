namespace Dev03
{
public class Word
{
    string use_this_verse;
    string verse;
    List<string> words_list_split;

    public void GetReference(string chap)
    {
        verse = chap;
    }
    public void GetVerse(List<string> list_arr)
    {
        words_list_split = list_arr;
    }

    Random rnd = new Random();
    List<int> hiddenIndexes = new List<int>();
    public void hidden_verse()
    {
        int indexToHide = rnd.Next(0, words_list_split.Count);
        while (hiddenIndexes.Contains(indexToHide))
        {
            indexToHide = rnd.Next(0, words_list_split.Count);
        }

        hiddenIndexes.Add(indexToHide);

        use_this_verse = "";
        for (int i = 0; i < words_list_split.Count; i++)
        {
            if (hiddenIndexes.Contains(i))
            {
                use_this_verse = use_this_verse + " " + "XXX";
                // Console.WriteLine(new string('X', words_list_split[i].Length));
            }
            else
            {
                use_this_verse = use_this_verse + " " + words_list_split[i];
                // Console.WriteLine(words_list_split[i]);
            }
        }
        Console.Clear();
        Console.WriteLine($"{verse}, {use_this_verse}");
    }
    }
}