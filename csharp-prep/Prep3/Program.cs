using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 100);

        bool ansCheck = false;
        do
        {

            Console.Write("Guess the number: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == magicNum)
            {
                Console.WriteLine("Thats Correct!!!");
                ansCheck = true;
            } else if (guess <= magicNum)
            {
                Console.WriteLine("Incorrect, guess Higher!!!");
            } else if (guess >= magicNum)
            {
                Console.WriteLine("Incorrect, Guess Lower!!");
            }
        } while (ansCheck != true);
    }
}