public class Reference
{
    private string book;
    private int chapter;
    private int verse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }

    public string Book
    {
        get { return book; }
        private set { book = value; }
    }

    public int Chapter
    {
        get { return chapter; }
        private set { chapter = value; }
    }

    public int Verse
    {
        get { return verse; }
        private set { verse = value; }
    }
}