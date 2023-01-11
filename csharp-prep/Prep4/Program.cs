using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int uNum = 0;
        int max = 0;
        int Sum = 0;
        Console.WriteLine("Enter a list of Numbers, type 0 when finished");
        do{
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();
            uNum = int.Parse(input);
            number.Add(uNum);
            if (uNum > max){
                max = uNum;
            }
            Sum = uNum + Sum;
        }while (uNum != 0);
        Console.WriteLine($"The sum is {Sum}");
        Console.WriteLine($"The average is {Sum/number.Count}");
        Console.WriteLine($"The maximum is {max}");
    }
}