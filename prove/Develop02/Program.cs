using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Random rnd = new Random();
        int num = rnd.Next(3);

        string response = "";


        List<string> _promptings = new List<string>();
        _promptings.Add("What is the highlight of today?");
        _promptings.Add("If you could change one thing you did today, what would it be?");
        _promptings.Add("What are you grateful for today?");

        // Display menu options
        Console.WriteLine("Welcome to Journal!");
        while (response != "Q")
        {
            Console.WriteLine("Pick from the following menu options:");
            Console.WriteLine("* [W]rite a new entry");
            Console.WriteLine("* [D]isplay the journal");
            Console.WriteLine("* [S]ave the journal to a file");
            Console.WriteLine("* [L]oad the journal from a file");
            Console.WriteLine("* [Q]uit");
            Console.Write("--> ");
            response = Console.ReadLine().ToUpper();

            switch (response) {
                case "W":
                    Entry entry = new Entry();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Write your diary for today. ({dateText})");
                    Console.WriteLine(_promptings[num]);
                    Console.Write("-->");
                    entry._text = Console.ReadLine();
                    entry._date = dateText;
                    Console.ResetColor();

                    journal.AddEntry(entry);

                    Console.WriteLine();

                    break;
                case "D":

                    journal.DisplayJournal();
                    Console.WriteLine();

                    break;
                case "S":

                    SaveToFile(journal._entries);

                    break;
                case "L":

                    List<Entry> newEntries = ReadFromFile();
                    Console.WriteLine();

                    break;
                case "Q":
                    break;
                
                default:
                    Console.WriteLine("Invalid response");
                    break;
            }
        }

    }

    public static void SaveToFile(List<Entry> _entries) {
        string filename = "journal.txt";

        Console.WriteLine("Save to a file...");
        Console.WriteLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._text}");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("Reading a list from a file...");
        Console.WriteLine();

        List<Entry> entries = new List<Entry>();
        string filename = "journal.txt";

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return entries;
    }
}