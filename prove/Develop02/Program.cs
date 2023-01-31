using System;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator.CreatePrompts();

        bool run = true;
        while (run)
        {
            //main menu list of choices
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?  ");

            string choice = Console.ReadLine().Trim();

            string randomPrompt = promptGenerator.ChooseRandomPrompt();

            if (choice == "1")
            {
                Console.WriteLine(randomPrompt);
                string entry = Console.ReadLine();

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
                run = false;
            }
            else 
            {
                Console.WriteLine($"\"{choice}\" is not a valid selection.  Please enter something between 1 - 5.");
            }
        }
    }
}