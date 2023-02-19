using System;

class Word
{
    //attributes
    public bool _show = true;
    public string _text;

    //Consructors
    public Word(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        _text = " ___ ";
        _show = false;
    }
}