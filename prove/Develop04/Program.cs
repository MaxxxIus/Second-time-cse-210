// used gemini to figure out how to make a string with \ without the code getting mad

using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Please type the number of the activty you'd like to do:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please type your choice now: ");
            answer = Console.ReadLine();
            Console.Clear();
            if (answer == "1")
            {
                Breathing act1 = new Breathing();
                act1.BeginActivity();
            } else if(answer == "2")
            {
                Reflection act1 = new Reflection();
                act1.BeginActivity();
            } else if(answer == "3")
            {
                Listing act1 = new Listing();
                act1.BeginActivity();
            }
        }
    }
}