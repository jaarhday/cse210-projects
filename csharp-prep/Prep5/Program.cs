using System;

class Program
{
    static void Main(string[] args){
        displayWelcome();
        string userName = getUserName();
        int userNum = getUserNum();

        int squareNum = getSquareNum(userNum);

        displayResult(squareNum, userName);
    }
    static void displayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string getUserName(){
        Console.Write("What is your username: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int getUserNum(){
        Console.Write("What is your user number: ");
        string input = Console.ReadLine();
        int userNum = int.Parse(input);
        return userNum;
    }
    static int getSquareNum(int userNum){
        int squareNum = userNum * userNum;
        return squareNum;
    }

    static void displayResult(int squareNum, string userName){
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }
}