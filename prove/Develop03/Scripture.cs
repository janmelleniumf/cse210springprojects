public class Scripture
{
    public Reference Reference { get; set; }
    public string Text { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        // Initialize the reference, text, and words
        Reference = reference;
        Text = text;
        Words = new List<Word>();

        // Split the text into individual words
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numWords)
    {
        // Hide a specified number of random words
        List<Word> words = Words;
        Random random = new Random();

        for (int i = 0; i < numWords; i++)
        {
            int randomIndex = random.Next(0, words.Count);
            Word word = words[randomIndex];
            word.IsHidden = true;
            words[randomIndex] = word;
        }
    }

    
    public string GetDisplayText()
    {
        // Return the display text with hidden words replaced with underscores
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