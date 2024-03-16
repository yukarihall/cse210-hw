//using System.IO;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public string filename;

  
  public void AddEntry()
  {
    //adding a new journal entry to a list Entry
    Entry entry = new Entry();
    entry.Write();
    _entries.Add(entry); 

  }

  public void DisplayAll()
  {
    foreach(Entry entry in _entries)
    {
      entry.Display();
    }
  }
  
  public void SaveToFile()
  {
    //Getting the file name here. 
    Console.WriteLine("What is the file name (???.txt) to save?: ");
    filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach(Entry entry in _entries)
      {          
        outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        Console.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");       
      }
    }
  }

  public void LoadFromFile()
  {
    //Getting the file name here.
    Console.WriteLine("What is the file name for your journal?: ");
    filename = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        string _date = parts[0];
        string _promptText = parts[1];
        string _entryText = parts[2];

        //for debag
        Console.WriteLine($"{_date}:{_promptText}:{_entryText}");
        
    }
  }
}