using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running run1 = new Running("4/6/2024", 50, 100);
        Cycling cycle1 = new Cycling("6/18/2026", 70, 10.5);
        Swimming swim1 = new Swimming("2/9/2026", 90, 10);
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.DisplaySummary());
        }
    }
}