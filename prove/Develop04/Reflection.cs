public class Reflection: Activity
{
    public Reflection(): base("Reflection",
    "In this activity, you will be asked questions about a subject, and be asked to ponder your answer to these questions.")
    {
        
    }

    public void BeginActivity()
    {
        StartEntrance();
        Console.WriteLine();
        Console.WriteLine("Consider the following:");
        Console.WriteLine($"---{GiveRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When your ready, press ENTER to continue.");
        Console.ReadLine();
        Console.Write("Now ponder the following questuions....");
        CountDown(5);
        Console.WriteLine();
        int timePassed = 0;
        while(timePassed < GetTime()){
            Console.Write(GiveQuestion());
            Pause(7);
            Console.WriteLine();
            timePassed += 14;
        }
            
        StartExit();
    }

    public String GiveRandomPrompt()
    {
        Random randiGen = new Random();
        int randiNum = randiGen.Next(0,3);
        if (randiNum == 1)
        {
            return "Think of a time you felt Gods love.";
        } else if (randiNum == 2){
            return "Think of a time you did something you where proud of.";
        } else if (randiNum == 3)
        {
            return "Think of a time you helped someone in need.";
        } else
        {
            return "Think of a time you backflipped over a fire breathing alegator.";
        }
    }

    public string GiveQuestion()
    {
        Random randiGen = new Random();
        int randiNum = randiGen.Next(0,3);
        if (randiNum == 1)
        {
            return "How has this experience effected your life?";
        }else if (randiNum == 2)
        {
            return "What made this experience important to you?";
        }else if (randiNum == 3)
        {
            return "Whats the most significant part of this memory?";
        }
        else
        {
            return "Your only seeing this because I messed up...... just think about that for 15 seconds";
        }
        
    }
}