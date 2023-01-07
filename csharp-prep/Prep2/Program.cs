using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        if (grade <= 100 && grade >=90){
            letter = "A";
            Console.WriteLine("You also passed the class! Congrats :)");
        }
        else if (grade < 90 && grade >=80){
            letter = "B";
            Console.WriteLine("You also passed the class! Congrats :)");
        }
        else if (grade < 80 && grade >= 70){
            letter = "C";
            Console.WriteLine("You also passed the class! Congrats :)");
        }
        else if (grade < 70 && grade >= 60){
            letter = "D";
            Console.WriteLine("You failed the class... better luck next time!");
        }
        else if (grade < 60){
            letter = "F";
            Console.WriteLine("You failed the class... better luck next time!");
        }
        Console.WriteLine($"You got a(n) {letter} in your class.");
    }
}