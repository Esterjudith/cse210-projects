using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        Console.WriteLine("Welcome to the Journal Program!");
        while (running)
        {   
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //write a new entry
                    string prompt = promptGenerator.GetRadomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                //Display all entries
                    journal.DisplayAll();
                    break;
                case "3":
                //Loading from file
                    Console.Write("Enter the filename to load: ");
                    string loadFile =   Console.ReadLine();
                    journal.SaveToFile(loadFile);
                    break;  
                case "4":
                    //Saving to a file
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);   
                    break;
                case "5":
                //Quit
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid number.");
                    break;

            }
        }
        
       

        // Job job1 = new Job();
        // Job job2 = new Job();   
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job1._startYear = 2019;
        // job1._endYear = 2022;
        // job2._startYear = 2022;
        // job2._endYear = 2023;
       

        // Resume resume = new Resume();
        // resume._name = "Allison Rose";

        // resume._jobs.Add(job1);
        // resume._jobs.Add(job2);
        
        // resume.Display();
        
    }
}