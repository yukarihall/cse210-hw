public class PromptGenerator
{
  public List<string> _prompts = new List<string>()

  {
    "What was the most excitment in this day?",
    "What things did make you happy today?",
    "Who did you think the most lovely person today?",
    "What and how many ware the blessings you get from Heavenly Father and Jesus today?",
    "Which scripture did strike you and why?"
  };

  public Random rng = new Random();

  public string GetRandomPrompt()
  {
    int index = rng.Next(0, _prompts.Count);
    return _prompts[index];
  }
}