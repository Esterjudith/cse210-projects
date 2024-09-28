using System.Collections.Generic;
using System.IO;

public class Journal
{
   public List<Entry> _entries = new List<Entry>();

   public void AddEntry(Entry newEntry)
   {
     _entries.Add(newEntry);
   }
   
   //Iterates through the entries. 
   public void DisplayAll()
   {
    foreach(Entry entry in _entries)
    {
        entry.Display();
        Console.WriteLine(); //blank space in between entries
    }
   }

  //SaveToFile takes the entry, date, and prompt and saves it as a file. 
   public void SaveToFile(string fileName)
   {
        using(StreamWriter writer = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            writer.WriteLine($"{entry._date}| {entry._promptText}|{entry._entryText}");
        }
   }
   public void LoadFromFile(string fileName)    
   {
        if(File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach(string line in lines)
            {
                string[] parts = line.Split('|');
                if(parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
            }
        }else
        {
            Console.WriteLine("File Not Found!");
        }
   }
   
}