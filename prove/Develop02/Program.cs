using System;
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {
        List<string> Journal = new List<string>();
        string userInput = "";
        while (userInput != "5"){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            userInput = Console.ReadLine();
            if (userInput == "1"){
                write entry = new write();
                entry._prompt = entry.getPrompt();
                entry._jEntry = entry.getEntry();
                entry._dateTime = entry.getDate();
                
            }
            else if (userInput == "2"){
                
            }
            else if (userInput == "3"){

            }
            else if (userInput == "4"){
                //write.Display();
            }
        }
    }
}