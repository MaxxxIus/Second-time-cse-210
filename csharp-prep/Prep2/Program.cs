using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = " ";
        Console.Write("What is your Grade percentage? ");
        float score = float.Parse(Console.ReadLine());
        if (score >= 90)
        {
            grade = "A";
        } else if (score >= 80)
        {
            grade = "B";
        } else if (score >= 70)
        {
            grade = "C";
        } else if (score >= 60)
        {
            grade = "D";
        } else
        {
          grade = "f";  
        }

        Console.WriteLine($"Your Grade: {grade}");
        if (score >= 70)
        {
            Console.WriteLine("Congrates!!! You passed!!");
        } else
        {
            Console.WriteLine("Too Bad. See you next semester!!!");
        }
    }
}