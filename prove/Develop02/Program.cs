using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        // Using while loop to display the menu
        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load from File");
            Console.WriteLine("4. Save to File");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            // converting the option into integer
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {   
                //AddEntry in Journal.cs method is used in the main using the case 1
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Random prompt: {prompt}");
                    journal.AddEntry(prompt);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                //Added an option to load the file for both txt and json
                case 3:
                    Console.Write("Enter a filename: ");
                    string loadFilename = Console.ReadLine();
                    Console.Write("Enter a file format (json or txt): ");
                    string format = Console.ReadLine();
                    journal.LoadFromFile(loadFilename, format);
                    journal.DisplayEntries();
                    break;
                // saving the file either json or txt
                case 4:
                    Console.Write("Enter a filename: ");
                    string saveFilename = Console.ReadLine();
                    Console.Write("Enter a file format (json or txt): ");
                    string fileFormat = Console.ReadLine();
                    journal.SaveToFile(saveFilename, fileFormat);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}