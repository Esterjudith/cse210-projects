
public class SimpleGoal : Goal
{

    private bool _isComplete;

   public SimpleGoal(string name, string description, int points) : base(name, description,points) 
   {
        _isComplete = false;
   }
    public override void RecordEvent()
    {
        if(!_isComplete)
        {          
            _isComplete = true;
            Console.WriteLine($"You've completed the goal: {_shortName}. You earned {_points} points!");

            GoalManager goalManager = new GoalManager();
            goalManager.AddPoints(_points);        
            
        }
        else 
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal - {_shortName}: {(isComplete() ? "[X]" :"[]")} {_description}";
    }
}