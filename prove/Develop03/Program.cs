using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        while (userInput != "3"){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Study");
            Console.WriteLine("2. Select a Scripture");
            Console.WriteLine("3. Quit");
            Console.Write("> ");
            userInput = Console.ReadLine();
            /************************************************************
            * open the scripture by calling scripture class, then call the 
            * write class and its methods to study the scripture
            ************************************************************/
            if (userInput == "1"){ 
                Scripture scripture = new Scripture(); // gets or creates scripture
                scripture._scriptures = scripture.toList();
                Words uStudy = new Words(); // methods for studying
            }
            else if (userInput == "2"){

            }
        }
        Console.WriteLine("Hello Develop03 World!");
    }
}