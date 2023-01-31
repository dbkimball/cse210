using System;
using System.IO;
using System.Text;

public class Journal
{
    
    public List<String> _entries = new List<String>();
    string _filename;

    DateTime theCurrentTime = DateTime.Now;

    public void AddEntry(string prompt, string entry)
    {
        string date = theCurrentTime.ToShortDateString();
        string formattedEntry = ($"Date: {date} - Prompt: {prompt}: \n{entry}");
        _entries.Add(formattedEntry);
    }
    public void DisplayEntry()
    {
       foreach (string line in _entries)
       {
            Console.WriteLine(line);
            Console.WriteLine();
       }
    }
      
    public void SaveJournalFile()
    {
        //only checks the relative path to the .exe
        Console.WriteLine("What would you like to name the file? ");
        _filename = Console.ReadLine();
        if (!File.Exists(_filename))
        {
            File.CreateText(_filename);
            using (StreamWriter textfile = new StreamWriter( _filename, true))
            {
                foreach (string line in _entries)
                textfile.WriteLine(line);
            
                textfile.Flush();
            }
        }
    }

    public void LoadJournalFile()
    {
        Console.WriteLine("What is the filename? ");
        string loadFile = Console.ReadLine();
        _filename = loadFile;

        _entries.Clear();

        string[] loadedEntries = File.ReadAllLines(_filename); 
        foreach (string loadEntry in loadedEntries)
        {
            _entries.Add(loadEntry);
        }
    }

}