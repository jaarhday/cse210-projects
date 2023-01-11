using System;

class Program
{
    static void Main(string[] args)
    {
        //string magicNumber = "";
        int gNum = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
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