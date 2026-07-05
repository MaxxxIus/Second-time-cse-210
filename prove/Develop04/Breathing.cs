public class Breathing: Activity
{
    public Breathing(): base("Breathing",
    "In this activity, you will rythmicly breath in and out to calm your nerves and refocus.")
    {
    }

    public void BeginActivity()
    {
        StartEntrance();
        int timeCount = 0;
        while (!(timeCount >= GetTime())){
            Breath();
            timeCount += 10;
        }
        StartExit();

    }
    public void Breath()
    {
        Console.WriteLine();
        Console.Write("Breath in....");
        CountDown(6);
        Console.WriteLine();
        Console.Write("Breath out....");
        CountDown(4);
        Console.WriteLine();
    }
}