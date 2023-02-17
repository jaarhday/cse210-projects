public class Words{
    private string reference;
    private string text;
    private bool[] hiddenWords;

    public Words(string text)
    {
        this.text = text;
        this.hiddenWords = new bool[text.Split(' ').Length];
    }

    public string getText()
    {
        string[] words = text.Split(' ');
        string displayedText = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (!hiddenWords[i])
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

    public void hideWords()
    {
        Random random = new Random();
        int wordIndex = random.Next(0, text.Split(' ').Length);

        hiddenWords[wordIndex] = true;
    }
}