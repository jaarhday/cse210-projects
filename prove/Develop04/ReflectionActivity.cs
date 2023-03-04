public class ReflectionActivity{
    private int _duration;
    private string _activityName = "Reflection Activity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
    public void StartActivity(){
        // get all the necessary thangs
        ActivityManager act2 = new ActivityManager(_activityName, _description);
        act2.sMessage();
        this._duration = act2.getDuration();

        Console.Clear();
        //Thread.Sleep(2000);

        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < _duration){
            int r_Prompt = new Random().Next(1, 4);
            int r_Reflection = new Random().Next(1, 9);
            Console.WriteLine();
            Console.WriteLine(_prompts[r_Prompt]);
            for (int i = 0; i < 10; i++){
                Console.Write($"{i+1}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine(_reflections[r_Reflection]);
            for (int i = 0; i < 10; i++){
                Console.Write($"{i+1}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{(_duration - ((DateTime.Now - start).TotalSeconds))} seconds left...");
        }
        /*int r_Prompt = new Random().Next(1, 4);
        int r_Reflection = new Random().Next(1, 9);
        Console.WriteLine(_prompts[r_Prompt]);
        act2.sleepyTime(_duration);
        Console.WriteLine(_reflections[r_Reflection]);
        act2.sleepyTime(_duration);
        act2.eMessage(_duration);*/
    }
}