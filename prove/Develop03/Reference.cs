partial class Program
{
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
    }
}