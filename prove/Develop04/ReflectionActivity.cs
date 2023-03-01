public class ReflectionActivity{
    private int _duration;
    private string _activityName = "Reflection Activity";
    private string _description = "";
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private string[] _reflections = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration){
        this._duration = duration;
    }
    
    public void StartActivity(){
        int r_Prompt = new Random().Next(1, 4);
        int r_Reflection = new Random().Next(1, 9);
    }
}