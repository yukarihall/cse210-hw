public class PromptGenerator
{
  public List<string> _prompts = 
  {
    "Prompt one...",
    "Another prompt..",
    "Third prompt..",
    "Fourth one",
    "Fifth..."
  };
  
  public Random rng = new Random();

  public string GetRandomPrompt()
  {
    int index = rng.Next(0, _prompts.Count);
    return _prompts[index];
  }
}