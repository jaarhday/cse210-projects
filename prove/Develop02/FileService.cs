using System.IO;
public class FileService{
    public List<string> _saveFile = new List<string>();
    public string _filename = "";

    public string GetFilename(){
        Console.WriteLine("What is the save file name for the Journal? ");
        _filename = Console.ReadLine(); //used to get the filename
        return _filename;
    }
    public void Save(){
        /*foreach (string i in _saveFile){ //debugger
            Console.WriteLine(i);
        }*/
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string i in _saveFile){
                outputFile.WriteLine(i); //writes all of that jazz :)
            }
        }
    }
    public List<string> Load(){
        string readText = File.ReadAllText(_filename);
        List<string> result = new List<string>(); // this sets the journal in the main program to whatever the load file is
        result.Add(readText);
        return result;
        //Console.WriteLine(readText); //debugger output
    }
    public void Display(){
        int i = 0; //iterate through and print specific things with the given information
        foreach (string line in _saveFile){
            if (i == 0){
                Console.WriteLine($"Date: {line}");
                i++;
            }
            else if (i == 1){      //this was a failed attempt to output each type of data with a different heading... didnt work lol
                Console.Write($" Prompt: {line}");
                i++;
            }
            else if (i == 2){
                Console.WriteLine($"{line}");
                Console.WriteLine();
                i = 0;
            }
        }
    }
}