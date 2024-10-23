public class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _count; // Member attribute to track the number of items listed

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    {
        _count = 0; // Initialize _count to 0
    }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]); // Randomly select a prompt from the list

        Console.WriteLine("You have a few seconds to begin thinking...");
        ShowCountdown(3); // Countdown to give the user time to think

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items now:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input); // Add input to the list
                _count++; // Increment the count for each valid input
            }
        }

        Console.WriteLine($"You listed {_count} items."); // Display the total count of listed items
        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}