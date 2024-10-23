public class Activity
{
     protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description= description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine(_description);
        Console.Write("Please enter the duration of the activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // pauses for 3 seconds
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(3); // pauses for 3 seconds
        Console.WriteLine($"You have completed the {_activityName} activity for {_duration} seconds.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

}