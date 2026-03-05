using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String grade = Console.ReadLine();
        int grade_percent = int.Parse(grade);
        String letter_grade;
        if (grade_percent >= 90)
        {
            letter_grade = "A";
        } else if (grade_percent >= 80)
        {
            letter_grade = "B";
        } else if (grade_percent >= 70)
        {
            letter_grade = "C";
        } else if (grade_percent >= 60)
        {
            letter_grade = "D";
        } else
        {
            letter_grade = "F";
        }

        Console.WriteLine(letter_grade);
    }
}