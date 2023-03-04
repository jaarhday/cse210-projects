using System.Threading;

public class ActivityManager{
    private string _activityName = "";
    private string _description = "";
    private int _duration;
    private string[] _aStrings = {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };
    public ActivityManager(string activityName, string description){
        this._activityName = activityName;
        this._description = description;
    }
    public void sMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n{_description}");
        //Thread.Sleep(2000);
    }
    public int getDuration(){
        Console.WriteLine();
        Console.WriteLine("How long would you like to take on this activity? (IN SECONDS):");
        string val = Console.ReadLine();
        int duration = Convert.ToInt32(val);
        this._duration = duration;
        return duration;
    }
    public void eMessage(int _duration){
        Console.Clear();
        Console.WriteLine($"Well done with the {_activityName}!\nYou performed this activity for {_duration} seconds!");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void sleepyTime(int _time){
        for (int i = 0; i < (_time/2); i++){
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }

    public void loadingAnimation(){
        DateTime start = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - start).TotalSeconds < _duration){
            string s = _aStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            if (i >= 8){
                i = 0;
            }
        }
    }
}