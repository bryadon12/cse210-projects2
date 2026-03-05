using System;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of numbers, type 0 when finished");
        List<int> numbers = [];
        int number = -1;
        int largestNumber = -1;
        double average;
        int sum = 0;
        while (number != 0)
        {
            Console.WriteLine("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
            numbers.Add(number);
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        
        average = sum/numbers.Count;
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
    }
}