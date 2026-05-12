using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int ans;
        do
        {
            Console.Write("Enter a number or enter 0 to move on: ");
            ans = int.Parse(Console.ReadLine());  
            if (ans != 0)
            {
                numbers.Add(ans);
            }
        } while (ans != 0);
        int total = 0;
        int maximum = numbers[0];

        foreach (int num in numbers)
        {
            total += num;
            if (num > maximum)
            {
                maximum = num;
            }

        }

        float ave = total / numbers.Count;
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {ave}");
        Console.WriteLine($"Maximum: {maximum}");

    }
}