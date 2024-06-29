public class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
}