using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine(" Please select the number (1-5) of the following choices. ");
        Console.WriteLine(" 1.write \r\n 2.display \r\n 3.load \r\n 4.save \r\n 5.quit");
        int JournalNumber = int.Parse(Console.ReadLine());

        string letter = "";

        if (JournalNumber == 1)
        {
            letter = "1.write.";
            journal.AddEntry();
        }
        else if (JournalNumber == 2)
        {
            letter = "2.display.";
            journal.DisplayAll();
        }
        else if (JournalNumber == 3)
        {
            letter = "3.load.";
            //journal.LoadFromFile();
        }
        else if (JournalNumber == 4)
        {
            letter = "4.save.";
            //journal.SaveToFile();
        }
        else if (JournalNumber == 5)
        {
            letter = "5.quit.";
            Apprication.Exit();           
        }
        else
        {
            letter = "Please select one of the following choices AGAIN!";
        }
        Console.WriteLine($"Your choice is: {letter}");
    }
}