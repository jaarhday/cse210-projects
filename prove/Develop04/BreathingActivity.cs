using System.Threading;
public class BreathingActivity{
    private int _duration;
    private string _activityName = "Breathing Activity";
    private string _description = "This activity will help you relax by walking your through\n breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void StartActivity(){
        ActivityManager act1 = new ActivityManager(_activityName, _description);
        act1.sMessage();
        this._duration = act1.getDuration();

        while (true){
            _duration = _duration - 1;
            //Console.WriteLine(_duration);
            Console.Clear();
            Console.WriteLine("Breath in...");
            for (int i = 0; i < 5; i++){
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Breath out...");
            for (int i = 0; i < 5; i++){
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
            if (_duration > 1){
                Console.WriteLine($"{_duration} more times before completion");
                act1.sleepyTime();
            }
            else if (_duration == 1){
                Console.WriteLine("One more time");
                act1.sleepyTime();
            }
            if (_duration == 0){
                act1.eMessage();
                break;
            }
        }
    }
}