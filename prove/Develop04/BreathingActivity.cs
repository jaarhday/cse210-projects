using System.Threading;
public class BreathingActivity{
    private int _duration;
    private string _activityName = "Breathing Activity";
    private string _description = "This activity will help you relax by walking your through\n breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void StartActivity(){
        ActivityManager act1 = new ActivityManager(_activityName, _description);
        act1.sMessage();
        this._duration = act1.getDuration();
        int loops = 0;
        if (_duration > 10){
            loops = _duration/10;
        }
        else {
            loops = 1;
        }
        Console.WriteLine(loops);

        while (true){
            loops = loops - 1;
            //Console.WriteLine(_duration);
            Console.Clear();
            Console.WriteLine("Breath in...");
            for (int i = 0; i < 5; i++){
                Console.Write($"{i+1}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();
            Console.WriteLine("Breath out...");
            for (int i = 0; i < 5; i++){
                Console.Write($"{i+1}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();
            if (loops > 1){
                Console.WriteLine($"{loops} more times before completion");
                Thread.Sleep(1000);
            }
            else if (loops == 1){
                Console.WriteLine("One more time");
                Thread.Sleep(1000);
            }
            if (loops == 0){
                act1.eMessage(_duration);
                break;
            }
        }
    }
}