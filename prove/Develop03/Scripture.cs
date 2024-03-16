partial class Program
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
    }
}