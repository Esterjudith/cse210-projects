public class Scripture 
{
    public Reference _reference;
    public List<Word> _word = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        

    }

    public void HideRamdomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }
    
    public bool isCompletelyHidden()
    {
        return false;
    }
}