public class FileService{
    public List<string> _saveFile = new List<string>();
    public string _filename = "";

    public void Save(){
        foreach (string i in _saveFile){
            File.WriteAllText("journal.txt", i);
        }
    }
    public void Load(){
        string readText = File.ReadAllText("journal.txt");
        Console.WriteLine(readText);
    }
    public void Display(){
        /*foreach (string line in _saveFiles){
            Console.WriteLine(line);
        }*/
    }
}