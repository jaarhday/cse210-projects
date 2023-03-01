using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Meditation Program!");
        string activity = "";
        while (true){
            Console.WriteLine("What activity would you like to do?\x0A 1) Breathing Activity\n 2) Reflection Activity\n 3) Listing Activity\n 4) Quit");
            activity = Console.ReadLine();

            if (activity == "1"){
                BreathingActivity _activity =  new BreathingActivity();
                _activity.StartActivity();
            }
            else if (activity == "2"){
            }
            else if (activity == "3"){
            }
            else{
                Console.WriteLine("Thank you for using the Mindfulness App, Have a nice day!");
                break;
            }
        }
    }
}