using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Meditation Program!");
        string activity = "";
        string durationString = "";
        int duration = 0;
        while (true){
            Console.WriteLine("What activity would you like to do?\x0A 1) Breathing ACtivity\n 2) Reflection Activity\n 3) Listing Activity\n >");
            activity = Console.ReadLine();
            Console.WriteLine("How long would you like to do this activity for? (Amount of Loops): ");
            durationString = Console.ReadLine();
            duration = Convert.ToInt32(durationString);

            if (activity == "1"){
                BreathingActivity _activity =  new BreathingActivity(duration);
            }
            else if (activity == "2"){
            }
            else if (activity == "3"){
            }
            else{
                break;
            }
        }
    }
}