using System.Threading;

public class ActivityManager{
    private string _activityName = "";
    private string _description = "";
    private int _duration;

    public ActivityManager(string activityName, string description){
        this._activityName = activityName;
        this._description = description;
    }
    public void sMessage(){
        Console.WriteLine($"Welcome to the {_activityName}\n{_description}");
        Thread.Sleep(2000);
    }
    public int getDuration(){
        Console.WriteLine("How long would you like to take on this activity?");
        string val = Console.ReadLine();
        int duration = Convert.ToInt32(val);
        this._duration = duration;
        return duration;
    }
    public void eMessage(){
        Console.WriteLine($"Well done with the {_activityName}!\nYou performed this activity {_duration} times!");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void sleepyTime(){
        for (int i = 0; i < 3; i++){
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
    }
}