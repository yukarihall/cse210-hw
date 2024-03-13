public class Entry
{
 public string _date;
 public string _promptText;
 public string _entryText;
 public PromptGenerator pgen = new PromptGenerator();

 public void Write()
 {
    _date = DateTime.Now.ToShortDateString();
    // _promptText should be here
    _promptText = pgen.GetRandomPrompt();
    // _entryText should be here
    Console.WriteLine(_promptText);
    _entryText = Console.ReadLine;
 }
 
 public void Display()
 {
    Console.WriteLine($"{_date} ({_promptText}): {_entryText}");
 }

}