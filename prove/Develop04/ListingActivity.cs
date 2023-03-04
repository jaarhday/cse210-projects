using System.Threading;
public class ListingActivity{
    private int _duration;
    private string _activityName = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void StartActivity(){
        //initialize the activity
        ActivityManager act3 = new ActivityManager(_activityName, _description);
        act3.sMessage();
        this._duration = act3.getDuration();
        Console.Clear();
        Thread.Sleep(2000);

        // get the prompts
        Random rand = new Random();
        string prompt = _prompts[rand.Next(1,4)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"You have {_duration/2} seconds to think...");
        Thread.Sleep(_duration/2 * 1000);
        Console.Write("Start listing!");
        //act3.loadingAnimation(); //i tried doing the animation thing and it just wouldn't work :/
        Console.WriteLine();
        //add items that were selected to list
        DateTime start = DateTime.Now;
        List<string> items = new List<string>();
        while ((DateTime.Now - start).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        //Thread.Sleep(2000);
        Console.Clear();
        // print back to user
        Console.WriteLine("Here are your items:");
        foreach (string item in items)
        {
            Console.WriteLine("- " + item);
        }
        Thread.Sleep(5000);
        act3.eMessage(_duration);
    }
}