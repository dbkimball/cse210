using System;

class Scripture
{
    //attributes
    public string _reference;

    private string _scriptureText = "But whatsoever thing persuadeth men to do evil, and believe not in Christ, and deny him, and serve not God, then ye may know with a perfect knowledge it is of the devil; for after this manner doth the devil work, for he persuadeth no man to do good, no, not one; neither do his angels, neither do they who subject themselves unto him.";

    private List<Word> _words = new List<Word>();
    private List<Word> _wordsRemaining = new List<Word>();

    //contstructors
    public Scripture()
    {
        //convert the scripture text to a list
        List<String> toList = _scriptureText.Split(' ').ToList();  

        foreach (String eachWord in toList)
        {
             Word word = new Word(eachWord);
            _words.Add(word);
        }
    }
    public Scripture(string scripture)
    {
        List<String> scripturetoList = scripture.Split(' ').ToList();

        foreach (String currentWord in scripturetoList)
        {
            Word word = new Word(currentWord);
            _words.Add(word);
        }
    }

    //Getter
    public void GetScriptureText()
    {
        Console.Write(_reference);
        foreach (Word word in _words)
        {

            Console.Write(word._text);
            Console.Write(" ");
        }
    }

    //Setter
    public void SetScripture(string scripture)
    {
        _scriptureText = scripture;
    }



    // Behaviors 
    public void HideRandomWords(int quantityOfWordsToHide)
    {

        Random randomGenerator = new Random();

        for (int i = 0; i < quantityOfWordsToHide; i++)
        {
            int randomIndex = randomGenerator.Next(0, _words.Count());

            _words[randomIndex].Hide();


        }

    }

    public bool FullyHidden()
    {
        foreach (Word wordObject in _words)
        {
            if (wordObject._show == false)
            {
                continue;
            }
            if (wordObject._show == true)
            {
                return true;
            }
        }

        return false;
    }
}