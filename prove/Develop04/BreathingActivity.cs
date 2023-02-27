using System.Threading;
public class BreathingActivity{
    private int _duration;

    public BreathingActivity(int duration){
        this._duration = duration;
    }

    public void StartActivity(){
        while (_duration > 0 && _duration != 0){
            _duration -= _duration;
            Console.WriteLine("Breath in...");
            for (int i = 0; i < 4; i++){
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Breath out...");
            for (int i = 0; i < 4; i++){
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
    }
}