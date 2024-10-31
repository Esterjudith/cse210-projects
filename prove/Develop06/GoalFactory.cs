public static class GoalFactory
{
    public static Goal CreateGoalFromData(string data)
    {
        string[] parts = data.Split(':');
        string goalType = parts[0];
        string[] details = parts[1].Split(',');

        switch (goalType)
        {
            case "SimpleGoal":
                return new SimpleGoal(details[0], details[1], int.Parse(details[2]));
            case "EternalGoal":
                return new EternalGoal(details[0], details[1], int.Parse(details[2]));
            case "ChecklistGoal":
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                return new ChecklistGoal(details[0], details[1], int.Parse(details[2]), target, bonus);
            default:
                throw new Exception("Unknown goal type.");
        }
    }
}
