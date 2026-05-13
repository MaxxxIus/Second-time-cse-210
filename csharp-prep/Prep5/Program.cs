using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome!!!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your number?: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void PromptUserBirthday(out int birthday)
        {
            Console.Write("What is your birthday?" );
            birthday = int.Parse(Console.ReadLine());
        }

        static int SquareNum(int num)
        {
            int newNum = num * num;
            return newNum;
        }

        static void DisplayResaults(string name, int num, int birthYear)
        {
            int age = 2026 - birthYear;
            Console.WriteLine($"{name}, your number squared is {num}!!!");
            Console.WriteLine($"{name}, You are {age} years old as of 2026!!!");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int birthday;
        PromptUserBirthday(out birthday);
        int numSquared = SquareNum(num);
        DisplayResaults(name, numSquared, birthday);
    }
}