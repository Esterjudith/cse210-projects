public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus}";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"ChecklistGoal '{_name}' progress made! Earned {_points} points.");
    }
}