public class ListingActivity : Activity
{   
    private int _count;
    private List<string> _prompts = new List<string>();

    public void Run()
    {

    }

    public string RandomPrompt()
    {
        return "";
    }

    public List<string> GetListingFromUser()
    {
        List<string> userList = new List<string>();

        Console.WriteLine("Enter items (type 'done' when finished):");

        string input;
        while((input = Console.ReadLine()) != "done")
        {
            userList.Add(input);
        }
        return userList;
    }
}