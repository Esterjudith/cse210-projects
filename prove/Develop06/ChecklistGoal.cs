
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

   public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description,points) 
   {    
        _amountCompleted = 0;        
        _target = target;
        _bonus = bonus;
   }

    public override void RecordEvent()
    {   
        _amountCompleted++;
        
            Console.WriteLine($"Recorded {_shortName}: {_points} points added. Progress: {_amountCompleted}/{_target}.");
            GoalManager goalManager = new GoalManager();
            goalManager.AddPoints(_points);   
    

        //Check if goal is now complete
        if(_amountCompleted == _target )
        {
            Console.WriteLine($"Congratulations! You've completed the goal '{_shortName}' and earned a bonus of {_bonus} points!");
            goalManager.AddPoints(_bonus);
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete.");
        }
        
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal - {_shortName}: {(isComplete() ? "[X]":"[]")} - Completed {_amountCompleted}/{_target} times";
    }
}