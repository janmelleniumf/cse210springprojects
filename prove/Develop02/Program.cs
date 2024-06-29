using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App!");
        int actionNum = -1;
        Journal journal = new Journal();

        do
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a new Entry");
            Console.WriteLine("2. Display the Journal data");
            Console.WriteLine("3. Open a saved file");
            Console.WriteLine("4. Save the journal");
            Console.WriteLine("0. Quit");
            Console.WriteLine();

            string userNum = ReadUserInput();
            actionNum = int.Parse(userNum);

            if(actionNum == 0)
            {
                break;
            }
            switch (actionNum)
            {
                case 1:
                    PromptGenerator generate = new PromptGenerator();
                    string prompt = generate.GeneratePrompt();
                    Console.WriteLine("Today's prompt: " + prompt);
                    journal.AddEntry(prompt);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    LoadFromFile(journal);
                    journal.DisplayEntries();
                    break;
                case 4:
                    SaveToFile(journal);
                    break;
                default:
                    Console.WriteLine("Invalid action number. Please try again.");
                    break;
            }
        } while (actionNum != 0);
    }

    private static string ReadUserInput()
    {
        return Console.ReadLine();
    }

    private static void LoadFromFile(Journal journal)
    {
        Console.Write("Enter the filename: ");
        string filename = ReadUserInput();
        Console.Write("Choose a file format (txt/json): ");
        string fileFormat = ReadUserInput();

        journal.LoadFromFile(filename, fileFormat);
       
    }

    private static void SaveToFile(Journal journal)
    {
        Console.Write("Enter the filename: ");
        string filename = ReadUserInput();
        Console.Write("Choose a file format (txt/json): ");
        string fileFormat = ReadUserInput();

        journal.SaveToFile(filename, fileFormat);
    }
}