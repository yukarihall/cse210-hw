class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Method to start the goal manager
    public void Start()
    {
        CreateGoal();
        DisplayPlayerInfo(); // Display player info
    }

    // Method to display player information
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    // Method to list goal names
    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    // Method to list goal details
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Method to create a new goal
    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
        
        Goal newGoal;
        switch (goalType.ToLower())
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }
        _goals.Add(newGoal);
    }

    // Method to record an event for a goal
    public void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();
        Goal goal = _goals.FirstOrDefault(g => g.GetStringRepresentation() == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal._points; // Update player score
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    // Method to save goals
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal._shortName}|{goal._description}|{goal._points}");
            }
        }
    }

    // Method to load goals
    public void LoadGoals()
    {
        _goals.Clear();
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    switch (type)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(shortName, description, points));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(shortName, description, points));
                            break;
                        case "ChecklistGoal":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                            break;
                        default:
                            throw new ArgumentException("Invalid goal type.");
                    }
                }
            }
        }
    }
}