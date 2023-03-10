using System;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator.CreatePrompts();

        Console.WriteLine("Welcome to the Journal Program!");

        bool run = true;
        while (run)
        {
            //main menu list of choices
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine().Trim();

            string randomPrompt = promptGenerator.ChooseRandomPrompt();

            if (choice == "1")
            {
                Console.WriteLine("This Journal can except multiple lines of text, write as much as you wish in your journal and then type 'exit' when finished.");
                Console.WriteLine(randomPrompt);
                string entry = "";
                
                //Added an advanced multi-line version so that it would except multiple lines of entries until the user enters exit.  
                bool shouldContinue = true;
                while (shouldContinue)
                {
                    string line = Console.ReadLine();
                    if(line.ToLower().Trim()== "exit")
                    {
                        shouldContinue = false;
                    }
                    else{
                        entry += line + "\n";
                    }
                }
                Journal.AddEntry(randomPrompt, entry);
            }
            else if(choice == "2")
            {
                Journal.DisplayEntry();
            }
            else if (choice == "3")
            {
                Journal.LoadJournalFile();
            }
            else if (choice =="4")
            {
                Journal.SaveJournalFile();
            }

            else if (choice =="5")
            {
                Console.WriteLine("Thank you for using the journal program!");
                run = false;
            }
            //added an exception to catch if anything is entered besides 1-5
            else 
            {
                Console.WriteLine($"\"{choice}\" is not a valid selection.  Please enter something between 1 - 5.");
            }
        }
    }
}