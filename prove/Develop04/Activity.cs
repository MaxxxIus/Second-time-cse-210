public class Activity
{
    private int _time;
    private string _name;
    private string _description;

    public Activity(string name, string descript)
    {
        _name = name;
        _description = descript;
    }

    public void SetTime()
    {
        Console.Write("Please set how long the activity should take in seconds: ");
        _time = int.Parse(Console.ReadLine());
    }

    public int GetTime()
    {
        return _time;
    }

    public void StartEntrance()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine();
        SetTime();
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        Pause(4);
    }

    public void StartExit()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
        Pause(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_time} seconds of the {_name} Activity.");
        Pause(4);
    }
    public void Pause(int loops)
    {
        int i = 0;
        while(i < loops)
        {
            //2 seconds per loop
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write('\\');
            Thread.Sleep(500);
            Console.Write("\b \b");
            i+=1;
        }
    }

        public void CountDown(int time)
    {
        int count = time;
        while (count != 0){
            Console.Write(count);
            Thread.Sleep(1000);
            count -= 1;
            Console.Write("\b \b");
        }
    }
}