using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromtUserBirthYear();


    }

    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcom to the program!");
    }

    public static string PromptUserName ()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }

    public static int PromptUserNumber()
    {
        Console.WriteLine("What is your facorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    public static int PromtUserBirthYear()
    {
        Console.WriteLine("What is your birth year?");
        return int.Parse(Console.ReadLine());
    }

    public static int SquareNumber(int number)
    {
        return number*number;
    }

    public static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} years old this year.");
    }
}