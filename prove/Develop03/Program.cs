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
        // scripture.GetScriptureText(); // Print original scripture
        // Console.WriteLine();
        // Console.WriteLine();

        // Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        
                
        while(scripture.FullyHidden() && userInput != "quit")
        {
            scripture.GetScriptureText();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            Console.Clear(); // Clear Console 
            scripture.HideRandomWords(8); 
            
        }
    }    

}    
