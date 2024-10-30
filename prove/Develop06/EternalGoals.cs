
public class EternalGoal : Goal
{

   public EternalGoal(string name, string description, int points) : base(name, description,points) 
   {
      
   }
    public override void RecordEvent()
    {
      
        Console.WriteLine($"Recorded progress for: {_shortName}.  You earned {_points} points!");
        GoalManager goalManager = new GoalManager();
        goalManager.AddPoints(_points);   
      
    }

    public override bool isComplete()
    {
        return false;  //Eternal goals are never complete.
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal - {_shortName}: {_description} - Earn {_points} points each time";
    }
}