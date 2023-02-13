public class Reference{
    private List<string> _info = new List<string>{"2 Nephi", "Chapter 2", "Verse 25"};
    public void Display(){
        foreach (string info in _info){
            Console.WriteLine(info);
        }
    }
}