using System;
using System.IO;

public class PromptGenerator
{
   //create an empty list of prompts
   public List<String> _prompts = new List<String>();

   Random randomGenerator = new Random();

   public void CreatePrompts()
   {
      string prompt1 = "What are you grateful for today?";
      _prompts.Add(prompt1);
      string prompt2 = "Did you witness an act of service today and how did it make you feel?";
      _prompts.Add(prompt2);
      string prompt3 = "What was the strongest emotion you have felt today and why?";
      _prompts.Add(prompt3);
      string prompt4 = "If you could say anything to your 20 year old self, what would it be and why?";
      _prompts.Add(prompt4);
      string prompt5 = "What are you goals for today";
      _prompts.Add(prompt5);
      string prompt6 = "What were your top 3 favorite things about today?";
      _prompts.Add(prompt6);
   } 

   public string ChooseRandomPrompt()
   {
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        return prompt;
   }
}