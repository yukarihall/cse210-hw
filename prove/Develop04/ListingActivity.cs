class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountDown(5);

        Console.WriteLine("Start listing items (type 'done' to finish):");
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            _count++;
        }

        Console.WriteLine($"Number of items listed: {_count}");

        DisplayEndingMessage();
    }
}