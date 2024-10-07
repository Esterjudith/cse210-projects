using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("Book of Mormon", 5, 1);  
        // // Console.WriteLine(reference.GetReference());

        // Word word = new Word("Water");
        // Console.WriteLine(word.GetDisplayText());
        // word.Hide();
        // Console.WriteLine(word.GetDisplayText());

        Reference reference = new Reference("John", 3, 6);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        

        while(true)
        {
      
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide some words or type 'quit to exit:" );
            string input = Console.ReadLine();                  
                  
            Console.Clear();
            
            if(input?.ToLower() == "quit")
            {
                break;
            }
            else
            {
                //Hide random word
                scripture.HideRamdomWords(1);
                if(scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
        }

    }
}