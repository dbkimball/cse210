using System;

class Program
{
    static void Main(string[] args)
    {
        //variables for original scripture reference
        string book = "Moroni";
        string chapter = "7";
        string verse = "17";
        string verse2 = ""; //only if needed

        string userInput = "";

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine();

        //object for scripture
        Scripture scripture = new Scripture();
        //object for reference
        Reference reference = new Reference(book, chapter, verse, verse2);

        //reference attribute for Scripture Class
        scripture._reference = reference.GetReference();

        //display original scripture

        
        Console.WriteLine("Press enter to continue or type 'quit' to quit");
        Console.ReadLine();

        while(scripture.FullyHidden())
        {
            scripture.GetScriptureText(); // Print original scripture
            userInput = Console.ReadLine(); // Waiting for enter key
            Console.Clear(); // Clear Console
            scripture.HideRandomWords(3); // Hide random words, int is number of words to hide

        }
    }
}