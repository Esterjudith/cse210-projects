public class Scripture 
{
    private Reference _reference;
    private List<Word> _word;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = new List<Word>();

        string[] words = text.Split(" ");

        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _word.Add(word);
        }

    }
    //For extra challenge the below method only hides words that are not already hidden.
    public void HideRamdomWords(int numberToHide)
    {
        Random random = new Random();
        int countHidden = 0;

        while(countHidden < numberToHide)
        {
            int randonIndex = random.Next(_word.Count);
            if(!_word[randonIndex].IsHidden())
            {
                 _word[randonIndex].Hide();
                countHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetReference()} {string.Join(" ", _word.Select(word => word.GetDisplayText()))}";
    }
    
    
    public bool IsCompletelyHidden()
    {
        return _word.All(w => w.IsHidden());  //Using LINQ 
    }
}