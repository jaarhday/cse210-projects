using System;
public class Scripture{
    public string n25 { get; } = "Adam fell that men might be and men are that they might have joy";
    public List<string> _scriptures = new List<string>();
    
    public List<string> toList(){
        List<string> _scriptures = n25.Split(' ').ToList();
        return _scriptures;
    }
}