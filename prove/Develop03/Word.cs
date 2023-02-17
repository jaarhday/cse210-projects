public class Words{
    private string _text;
    private bool[] _hiddenWords;

    public Words(string text)
    {
        this._text = text;
        this._hiddenWords = new bool[text.Split(' ').Length];
    }

    public string GetText()
    {
        string[] words = _text.Split(' ');
        string displayedText = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (!_hiddenWords[i])
            {
                displayedText += words[i] + " ";
            }
            else
            {
                displayedText += "_ ";
            }
        }

        return displayedText.Trim();
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordIndex = random.Next(0, _text.Split(' ').Length);

        _hiddenWords[wordIndex] = true;
    }
}