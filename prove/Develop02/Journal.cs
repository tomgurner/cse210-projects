using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filePath)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (Entry newEntry in _entries)
                {
                    outputFile.WriteLine($"{newEntry._date} || {newEntry._promptText} || {newEntry._entryText}");
                }
            }

            Console.WriteLine("Journal saved to file: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in saving file {ex.Message} ");
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Entry newEntry = new Entry();
            newEntry._date = parts[0].Trim();
            newEntry._promptText = parts[1].Trim();
            newEntry._entryText = parts[2].Trim();

            _entries.Add(newEntry);
        }
    }
}