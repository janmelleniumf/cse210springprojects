public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public int EndVerse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = startVerse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (Verse == EndVerse)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        else
        {
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        }
    }
}