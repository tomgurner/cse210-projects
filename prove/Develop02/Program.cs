// - Some Json is used in the Save selection but not familiar enough
// to use excessively yet. 
// - 13 Random prompts including 8 on top of the suggested prompts
// from the assignment. 
// - Comments to help breakup the different sections of the written code. 
// - Error exceptions and handling at lines 81 in the Load command. Also 
// at line 37 in Journal class.  


using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }
    static void DisplayMenu()
    {
        Journal journal = new Journal();

        while (true)
        {
            // Menu
            Console.WriteLine("Please select from one of the following options: ");

            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.WriteLine("");

            Console.WriteLine("What would you like to do? ");

            string selection = Console.ReadLine();


            // Write Selection
            if (selection == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM-dd-yyyy");
                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {newEntry._promptText}");
                Console.WriteLine("> ");
                newEntry._entryText = Console.ReadLine();
                journal.AddEntry(newEntry);

                journal.DisplayAll();

                Console.WriteLine("Enter filename to save journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Saving... ");
                Console.WriteLine("Entries saved successfully. ");
            } // End Write Selection


            // Display Selection
            else if (selection == "2")
            {
                journal.DisplayAll();
            } // End Display


            // Load Selection
            else if (selection == "3")
            {
                try
                {
                    Console.WriteLine("Enter filename: ");
                    string loadFilename = Console.ReadLine();
                    Console.WriteLine($"Attempting to load file: {loadFilename}...");
                    string readText = File.ReadAllText(loadFilename);
                    Console.WriteLine(readText);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found. Try again...");
                }
            } // End Load Selection


            // Save Selection
            else if (selection == "4")
            {
                Console.WriteLine("Enter filename to save: ");
                string filename = Console.ReadLine();
                string serializedEntries = JsonSerializer.Serialize(journal._entries);
                File.WriteAllText(filename, serializedEntries);
                Console.WriteLine("Saving...");
                Console.WriteLine("Entries saved successfully! ");
            } // End Save Selection


            // Quit Selection
            else if (selection == "5")
            {
                break;
            } // End Quit Selection

            else
            {
                Console.WriteLine("Invalid selection. Please try again");
            }

            // Console.Clear();

        } // End Menu Selection
    } // End Main
} // End Program