using System;

class Program
{
    static void Main(string[] args)
    {
        string magicNumber = "";
        int gNum = 0;
        Console.WriteLine("What is your magic number: ");
        magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        do{
            Console.Write("What is your guess: ");
            string guess = Console.ReadLine();
            gNum = int.Parse(guess);
            if (gNum > number){
                Console.WriteLine("Lower");
            }
            else if (gNum < number){
                Console.WriteLine("Higher");
            }
        }while (gNum != number);
        Console.WriteLine("You guessed it!");
    }
}