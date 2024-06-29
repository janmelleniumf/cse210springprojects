using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt)
    {
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response, DateTime.Now);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void LoadFromFile(string filename, string format)
    {
        if (format.ToLower() == "json")
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        else if (format.ToLower() == "txt")
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Entry entry = new Entry(parts[0], parts[1], DateTime.Parse(parts[2]));
                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("Invalid file format. Please try again.");
        }
    }

    public void SaveToFile(string filename, string format)
    {
        if (format.ToLower() == "json")
        {
            string json = JsonSerializer.Serialize(_entries);
            File.WriteAllText(filename, json);
        }
        else if (format.ToLower() == "txt")
        {
            List<string> lines = new List<string>();
            foreach (Entry entry in _entries)
            {
                lines.Add($"{entry.Prompt},{entry.Response},{entry.Date}");
            }
            File.WriteAllLines(filename, lines);
        }
        else
        {
            Console.WriteLine("Invalid file format. Please try again.");
        }
    }
}