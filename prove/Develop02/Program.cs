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
                //entry.display(); // debugger display
                Journal.Add(entry._dateTime); // adds to intermidiary list to put into the save file
                Journal.Add(entry._prompt);
                Journal.Add(entry._jEntry);
                /*foreach (string j in Journal){ // debugger output to make sure list is filled properly
                    Console.WriteLine(j);
                }*/
            }
            else if (userInput == "2"){
                FileService jSave = new FileService();
                jSave._filename = "journal.txt";
                foreach (string j in Journal){ // adds each part of the Journal to a save file
                    jSave._saveFile.Add(j);
                }
                jSave.Save();
            }
            else if (userInput == "3"){
                //Console.WriteLine($"{jSave._filename}");
            }
            else if (userInput == "4"){
                //write.Display();
            }
        }
    }
}