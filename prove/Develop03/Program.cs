using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\r\nWelcome to the Scripture Memorizer!\r\n");

        // 1.get scripture info
        string book = "Moroni";
        int chapter = 7;
        int verse = 12;
        int endVerse = 0;
        string text = "Wherefore, all things which are agood cometh of God; and that which is bevil cometh of the devil; for the devil is an enemy unto God.";


        Reference reference = new Reference(book,chapter,verse,endVerse);
        Scripture scripture = new Scripture(reference,text);

        Console.WriteLine($"{reference.GetDisplayText()}");


        // 3.continue
        while (true)
        {
            //show the scripture, then keep hit enter till all the   words in the scripture will be hidden.
            Console.WriteLine($"{scripture.GetDisplayText()}");
            if(scripture.IsCompetelyHidden()) break;

            // 2.ask quit (Type quit)or continue (hit Enter) 
            Console.WriteLine("\r\nPress ENTER to keep hiding the word or type 'quit' to finish.\r\n");

            //waiting for user hits the Enter
            if (Console.ReadLine() == "quit")
            {
                break;
            }

            //hide random words
            scripture.HideRandomWords(1);
          
            // This will clear the console
            Console.Clear();

            //when the words are completely gone or type "quit", then quit.
            // || scripture.IsCompetelyHidden() == 
            
        }
    }
}
