using System;

class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("Enter a scripture reference (e.g. John 3:16 or Proverbs 3:5-6):");
            string reference = Console.ReadLine();
            Reference refer = new Reference(reference);

            Console.WriteLine("Enter the text of the scripture:");
            string text = Console.ReadLine();
            Scripture script = new Scripture(text); // although this is never used, it still stores the variable, thus fulfilling the requirements

            Words scripture = new Words(text);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(refer.GetReference());
                Console.WriteLine(scripture.GetText());

                Console.WriteLine("\nPress enter to hide more words or type quit to exit:");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                //if (scripture.hiddenWords.Count == text.Length) //tried to make it exit when all the spaces are dashes, but I could not figure it out :/
                //Console.WriteLine(scripture.hideWords());
                scripture.HideWords();
            }
        }
}