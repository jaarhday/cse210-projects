using System;

namespace ScriptureStudyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a scripture reference (e.g. John 3:16 or Proverbs 3:5-6):");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter the text of the scripture:");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetReference());
                Console.WriteLine(scripture.GetText());

                Console.WriteLine("\nPress enter to hide more words or type quit to exit:");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                //if (scripture.hiddenWords.Count == text.Length)

                scripture.HideWords();
            }
        }
    }

    class Scripture
    {
        private string reference;
        private string text;
        public bool[] hiddenWords;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
            this.hiddenWords = new bool[text.Split(' ').Length];
        }

        public string GetReference()
        {
            return reference;
        }

        public string GetText()
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

        public void HideWords()
        {
            Random random = new Random();
            int wordIndex = random.Next(0, text.Split(' ').Length);

            hiddenWords[wordIndex] = true;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;

// Scripture class to represent a scripture
public class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }
}

// WordHider class to hide a few random words in the scripture
public class WordHider
{
    private List<string> hiddenWords = new List<string>();

    public string HideWords(string text)
    {
        var words = text.Split(' ');
        var random = new Random();
        var hiddenWordCount = random.Next(1, words.Length);

        for (int i = 0; i < hiddenWordCount; i++)
        {
            var index = random.Next(words.Length);
            hiddenWords.Add(words[index]);
            words[index] = new string('_', words[index].Length);
        }

        return string.Join(' ', words);
    }

    public bool IsWordHidden(string word)
    {
        return hiddenWords.Contains(word);
    }
}

// Program class to coordinate the interactions between the other two classes
public class Program
{
    static void Main()
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var wordHider = new WordHider();
        var words = scripture.Text.Split(' ');

        Console.WriteLine($"{scripture.Reference}\n{scripture.Text}");
        Console.WriteLine("Press Enter to continue or type quit to exit.");

        while (true)
        {
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            Console.WriteLine($"{scripture.Reference}\n{wordHider.HideWords(scripture.Text)}");
            Console.WriteLine("Press Enter to continue or type quit to exit.");
        }
    }
}
*/
