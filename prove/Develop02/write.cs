public class write{
    public string jEntry = "";
    public string dateTime = "";
    public List<string> Journal = new List<string>();
    public string[] Prompts = {
    "The most terrifying moment of my life was: ",
    "The most fun I’ve ever had: ",
    "The most surprised I’ve ever been: ",
    "The most disappointed I’ve ever been:",
    "What are you looking forward to the most?",
    "Three pet peeves:",
    "My saddest memory is:",
    "Some of the things that make me happy are:",
    "How do you deal with anger?",
    "My favorite Sunday ritual:",
    "The Holiday traditions I most look forward to:",
    "If you could have dinner with anyone currently alive, who would it be?",
    "If you could meet any fictional character, who would it be?",
    "If you could change one thing about your present life, what would it be?",
    "Write a letter to someone you need to forgive.",
    "Write a letter to someone who believed in you even when you didn’t believe in yourself."};

    public write(){
    }
    public void Display(){
        foreach (string line in Journal){
            Console.WriteLine(line);
        }
    }
    public void Write(){
        int random_number = new Random().Next(1, 16);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(Prompts[random_number]);
        Console.Write("> ");
        jEntry = Console.ReadLine();
        Journal.Add(dateText);
        Journal.Add(jEntry);
    }
}