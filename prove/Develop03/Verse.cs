namespace Dev03
{

public class Verse
{
    Dictionary<string, string> verses = new Dictionary<string, string>(){
        // {"Matthew 5:14-15", "Ye are the alight of the world. A city that is set on an hill cannot be hid. Neither do men light a acandle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house."},
        {"1 Nephi 33:1", "And now I, Nephi, cannot write all the things which were taught among my people; neither am I amighty in writing, like unto speaking; for when a man bspeaketh by the power of the Holy Ghost the power of the Holy Ghost carrieth it unto the hearts of the children of men."}
    };

    public Dictionary<string,string> GetVerse()
    {
        return this.verses;
    }
}
}