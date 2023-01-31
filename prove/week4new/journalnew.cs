using System;
using System.IO;

public class Journal
{
    public List<String> _entries = new List<String>();  //list of entries
    string _filename; // attribute for filename

    DateTime theCurrentTime = DateTime.Now; // date/time object
   
    public void Run()
    {
        DisplayIntro();
        //
        MainMenu();
        DisplayOutro();
    }

    public void MainMenu()
    {
       string choice;
       do
       {
            choice = UserChoice();
            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    DisplayJournalContents();
                    break;
                case "3":
                    DisplayJournalContents();
                    break;
                // case "4":
                //     SaveJournal();
                //     break;
                default:
                    break;

            }
       }while (choice != "5");
       
    }

    public void UserChoice()
    {
        bool isChoiceValid = false;
        string choice = "";

        do{
            // Console.Clear();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            
            choice = Console.ReadLine().Trim();

            //if user choice is 1 - write
                if (choice == "1")
                {
                   isChoiceValid = true;
                }
                else{
                    Console.WriteLine($"\" {choice}\" is not a valid selection.  Please enter a number between 1 - 5.");
                    //ReadKey(true);
                }
        } while (!isChoiceValid);

        //return choice;

    }
    public void CreateJournalFile() 
    {
        if (!File.Exists("MyJournal.txt"))
        {
            File.CreateText("MyJournal.txt");
        }
    }
    public void DisplayIntro()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        // ReadKey(true);
    }
    public void DisplayOutro()
    {
        Console.WriteLine("Thank you for using the journal!");
        // ReadKey(true);
    }
    public void DisplayJournalContents()
    {
        string journalText = File.ReadAllText(JournalFile);
        Console.WriteLine("\n=== Journal Contents ===");
        Console.WriteLine(journalText);
        Console.WriteLine("===========================");
        
    }
    public void ClearFile()
    {
        File.WriteAllText(JournalFile,"");
        Console.WriteLine("\nJournalCleared!");
        
    }
    public void AddEntry()
    {
        Console.WriteLine("\nWhat would you like to add? ");
        string newLine = Console.ReadLine();
        File.AppendAllText(JournalFile, $"\nEntry:\n> {newLine}\n");
        Console.WriteLine("The Journal has been modified!");
        
    }

    
}