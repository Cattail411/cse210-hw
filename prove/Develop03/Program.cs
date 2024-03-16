using System;

class Program
{
    static void Main(string[] args)
    {
        class Scripture
            {
                Reference: Reference;
                words: List<Word>;
                Scripture(Reference reference, TextReader);
                HideRandomWords(numberToHide: int);
                GetDisplayText();
                IsCompletelyHidden();
            }
        class Reference
            {   
                Book: string;
                Chapter: int;
                Verse: int;
                endVerse: int;
                Reference(string book, int chapter, int verse, int endVerse);
                Reference(string book, int chapter, int startVerse, int endVerse);
                GetDisplayText();
            }
        class Word
            {
                Text: string;
                IsHidden: bool;
                Word(TextReader);
                Hide();
                Show();
                IsHidden();
                GetDisplayText();
            }
    Console.clear;
    }
}