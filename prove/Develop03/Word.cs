public class Word
{
    public string Text { get; private set; }
    private bool isHidden;

    public Word(string text)
    {
        Text = text;
        isHidden = false;
    }

    public bool IsHidden
    {
        get { return isHidden; }
    }

    public void SetHidden(bool value)
    {
        isHidden = value;
    }
}