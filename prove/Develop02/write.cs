public class write{
    public string _jEntry = ""; //stores the entry
    public string _dateTime = ""; //stores the date
    public string _prompt = ""; // the prompt string that stores the prompt
    //public List<string> Journal = new List<string>();
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
    
    public string getPrompt(){
        int random_number = new Random().Next(1, 16);
        _prompt = Prompts[random_number];
        return _prompt;
    }
    public string getEntry(){
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _jEntry = Console.ReadLine();
        return _jEntry;
    }
    public string getDate(){
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();
        return _dateTime;
    }

    /*public List<string> Write(){
        int random_number = new Random().Next(1, 16);
        prompt = Prompts[random_number];
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(prompt);
        Console.Write("> ");
        jEntry = Console.ReadLine();
        Journal.Add(dateText);
        Journal.Add(prompt);
        Journal.Add(jEntry);
        foreach (string line in Journal){
            Console.WriteLine(line);
        }
        return Journal;
    }*/
    /*public void Display(){
        foreach (string line in Journal){
            Console.WriteLine(line);
        }
    }*/
}