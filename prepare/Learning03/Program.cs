using System;

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

                scripture.HideWords();
            }
        }
    }

    class Scripture
    {
        private string reference;
        private string text;
        private bool[] hiddenWords;

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
