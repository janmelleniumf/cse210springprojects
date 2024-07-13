public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public Reference Reference { get { return _reference; } }
    public string Text { get { return _text; } }
    public List<Word> Words { get { return _words; } }

    public void HideRandomWords(int numWords)
    {
        Random random = new Random();

        for (int i = 0; i < numWords; i++)
        {
            int randomIndex = random.Next(0, Words.Count);
            Word word = Words[randomIndex];
            word.SetHidden(true);
            Words[randomIndex] = word;
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in Words)
        {
            if (word.IsHidden)
            {
                displayText += new string('_', word.Text.Length) + " ";
            }
            else
            {
                displayText += word.Text + " ";
            }
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in Words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}