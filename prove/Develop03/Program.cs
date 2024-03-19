using System;

class Program
{
    static void Main(string[] args)
    {
       // 1.get scripture
       // 2.ask quit (Type quit)or continue (hit Enter) 
       // 3.continue
       //   show the scripture, then keep hit enter till all the   words in the scripture will be hidden.
       //   when the words are completely gone, then quit.


       // This will start by displaying "AAA" and waiting for the     user to press the enter key
        Console.WriteLine("AAA");
        Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        Console.WriteLine("BBB");
    }
}
