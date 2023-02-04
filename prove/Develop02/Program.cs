using System;
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {
        /********************************************************************
        * Declaring the variable, the Journal list is used to store the journal
        * info. This was the only way I could figure out how to keep a variable
        * outside the while loop that the abstraction classes and methods could 
        * refer back to.
        ********************************************************************/
        List<string> Journal = new List<string>();
        string userInput = "";
        /*********************************************************************
        * This is the while loop that runs while the program is running to 
        * give the user a menu
        *********************************************************************/
        while (userInput != "5"){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            userInput = Console.ReadLine();
            // Get the entry and store it into Journal
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
            // Displays the entry
            else if (userInput == "2"){
                FileService jDisplay = new FileService();
                jDisplay._saveFile = Journal;
                jDisplay.Display();
            }
            // Saves the entry
            else if (userInput == "3"){
                FileService jSave = new FileService();
                jSave._filename = jSave.GetFilename();
                //file = jSave._filename;
                foreach (string j in Journal){ // adds each part of the Journal to a save file
                    jSave._saveFile.Add(j);
                }
                /*foreach (string i in jSave._saveFile){ // debugger output to make sure list is filled properly
                    Console.WriteLine(i);
                }*/
                jSave.Save();
            }
            // Loads the entry
            else if (userInput == "4"){
                FileService jLoad = new FileService();
                jLoad.GetFilename();
                Journal = jLoad.Load();
            }
        }
    }
}