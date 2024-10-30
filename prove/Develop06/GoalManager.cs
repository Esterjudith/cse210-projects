using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        // Load goals and set up menu for user input
    }

    public void DisplayPlayerInfo()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalNames()
    {
         Console.WriteLine("\n--- Goals ---");
        for (int i = 0; i < _goals.Count; i++)
       {
            
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
       }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine($"Simple Goal '{name}' created!");
                break;
            case "2":
            
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine($"Eternal Goal '{name}' created!");
                break;
            case "3":
            
                Console.Write("Enter target completion count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine($"Checklist Goal '{name}' created with a target of {target} completions!");
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
         Console.WriteLine("Enter the name of the goal you want to record:");
        string goalName = Console.ReadLine();
    
        Goal goal = _goals.Find(g => g.GetDetailsString().Contains(goalName));

        if (goal != null)
        {
            goal.RecordEvent();
            
            if (int.TryParse(goal.GetStringRepresentation(), out int points))
            {
                _score += points;
                Console.WriteLine($"Your current score is: {_score}");
            }
        }
        else
        {
            Console.WriteLine("Goal not found. Please enter a valid goal name.");
        }
    }

    public void SaveGoals()
    {
       
           
    }

    public void LoadGoals()
    {
        
    }

    public void AddPoints(int points)
    {
         _score += points;
    }
}