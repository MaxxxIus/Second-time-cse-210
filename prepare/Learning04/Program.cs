using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment ass1 = new MathAssignment("John", "math", "7.3", "8-19");
        Console.WriteLine(ass1.GetSummary());
        Console.WriteLine(ass1.GetHomeworkList());

        WrittingAssignment ass2 = new WrittingAssignment("Mike Smite", "English History", "The End of the AMercan Revolution");
        Console.WriteLine(ass2.GetSummary());
        Console.WriteLine(ass2.GetWritingInfo());
    }
}