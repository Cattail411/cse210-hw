using System;
using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome {name}! Let's start journaling.");

        JournalEntry[] entries = new JournalEntry[3];

        for (int i = 0; i < entries.Length; i++)
        {
            entries[i] = new JournalEntry();
            entries[i].PromptForEntry();
            entries[i].DisplayEntry();
        }
        DateTime now = DateTime.Now;
        string dateText = now.ToString("MM/dd/yyyy");
        var titleCase = new TitleCaselib();
        var camel = new camelCase();
    }

    public class JournalEntry
    {
        internal static string txt;

        public string Prompt { get; set; }
        public string Entry { get; set; }

        public void PromptForEntry()
        {
            Console.WriteLine("What is your journal entry?");
            Entry = Console.ReadLine();
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"{Prompt}: {Entry}");
        }
    }
   
public void createJournalFile(string fileName)
    {
        if (File.Exists(JournalEntry.txt))
        {
            return;
        }
        File.CreateText(fileName);
    }
}

internal class TitleCaselib
{
}