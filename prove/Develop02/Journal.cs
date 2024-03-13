public class Journal
{
  public List<Entry> _entries;
  
  public void AddEntry(Entry newEntry)
  {
    //adding a new journal entry to a list Entry
    Entry entry = new Entry();
    entry.Write()
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
    Console.WriteLine("What is the file name to save?: ");
    filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach(Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry}");    
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
        string firstName = parts[0];
        string lastName = parts[1];
    }
  }
}