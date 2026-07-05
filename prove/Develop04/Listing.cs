public class Listing: Activity
{
    public Listing(): base("Listing", 
    "In this activity, you'll be given a prompt and then you will write down as many responses as you can within the time of the prompt.")
    {
        
    }

    public void BeginActivity()
    {
        StartEntrance();
        Console.WriteLine();
        Console.WriteLine("Write as much as you can about the following prompt:");
        Console.WriteLine($"---{GetPrompt()}---");
        Console.Write("You can begin in: ");
        CountDown(9);
        Console.WriteLine();

        DateTime targetTime = DateTime.Now;
        targetTime = targetTime.AddSeconds(GetTime());
        while (DateTime.Now < targetTime)
        {
            Console.Write(">");
            Console.ReadLine();
        }
        StartExit();
    }

    public string GetPrompt()
    {
        Random randiGen = new Random();
        int randiNum = randiGen.Next(0, 3);
        if (randiNum == 1)
        {
            return "What are some importent people you meet in your life.";
        }else if(randiNum == 2)
        {
            return "How have you felt the holy Ghost this week.";
        }else if(randiNum == 3)
        {
            return "What are some of the accomplishments from this week.";
        }
        else
        {
            return "I hate you";
        }
    }
}