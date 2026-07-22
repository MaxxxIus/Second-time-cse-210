using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        int pointTotal = 0;
        string userChoice = "";
        List<Goal> goalCollection = new List<Goal>();

        while (userChoice != "6")
        {
            Console.Clear();
            Console.WriteLine($"Points: {pointTotal}");
            Console.WriteLine();
            Console.WriteLine("Your options are as follows:");
            Console.WriteLine("1. Creat new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Report Progress");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quite");
            Console.WriteLine();
            Console.Write("Please make your Selection: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("Please Choose the nature of your goal:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. List Goal");
                Console.WriteLine("3. Check List Goal");
                Console.Write("Please make your choice: ");
                string subChoice = Console.ReadLine();

                Console.Write("Please give your goal a title: ");
                string name = Console.ReadLine();
                Console.Write("Please provide a description of your goal: ");
                string descript = Console.ReadLine();
                if (subChoice == "1")
                {
                    Console.Write("How many points will this goal be worth: ");
                    int point = int.Parse(Console.ReadLine());
                    Simple simple1 = new Simple(name, descript, point);
                    goalCollection.Add(simple1);

                } else if(subChoice == "2")
                {
                    Console.Write("How many points will each completion be worth: ");
                    int point = int.Parse(Console.ReadLine());
                    List list1 = new List(name, descript, point);
                    goalCollection.Add(list1);
                }else if(subChoice == "3") 
                {
                    Console.Write("How much will each completion be worth: ");
                    int point = int.Parse(Console.ReadLine());
                    Console.Write("How much will  it be worth upon completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.Write("How many times will it be done before completion: ");
                    int endGoal = int.Parse(Console.ReadLine());
                    CheckList check1 = new CheckList(name, descript, point, bonus, endGoal);
                    goalCollection.Add(check1);
                }
            } else if(userChoice == "2")
            {
                Console.WriteLine("Your Goals:");
                foreach (Goal goal in goalCollection)
                {
                    Console.WriteLine(goal.GetGoalString());
                }
                Console.ReadLine();
            } else if(userChoice == "3")
            {
                Console.WriteLine("Which goal did you progress:");
                int i = 1;
                foreach (Goal goal in goalCollection)
                {
                    Console.WriteLine($"{i}. {goal.GetName()}");
                    i++;
                }
                Console.WriteLine();
                Console.Write("Please make your selection: ");
                int subChoice = int.Parse(Console.ReadLine());
                subChoice -= 1;
                //Console.WriteLine(goalCollection[subChoice].ProgressedGoal());
                pointTotal += goalCollection[subChoice].ProgressedGoal();
            } else if (userChoice == "4")
            {
                Console.Write("Please name the file: ");
                string fileName = Console.ReadLine() + ".txt";
                string baseDataString = $"base||{pointTotal}"; 
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(baseDataString);
                    foreach (Goal goal in goalCollection)
                    {
                        outputFile.WriteLine(goal.GetSaveString());
                    }
                }
            }else if (userChoice == "5")
            {
                Console.Write("What is the name of the file your using: ");
                string fileName = Console.ReadLine() + ".txt";
                String[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] data = line.Split("||");
                    if (data[0] == "base")
                    {
                        pointTotal = int.Parse(data[1]);
                    }else if (data[0] == "simple")
                    {
                        Simple simple1 = new Simple();
                        simple1.LoadInfo(data);
                        goalCollection.Add(simple1);
                    }else if (data[0] == "list")
                    {
                        List list1 = new List();
                        list1.LoadInfo(data);
                        goalCollection.Add(list1);
                    }else if (data[0] == "check")
                    {
                        CheckList check1 = new CheckList();
                        check1.LoadInfo(data);
                        goalCollection.Add(check1);
                    }
                }
            }
        }
    }
}