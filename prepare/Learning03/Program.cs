using System;
/*
    google AI search resault: Prompt: "how to make an int into a double c#"
*/

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random randomGen = new Random();

        for (int i=0; i < 20; i++)
        {
            int ranNum = randomGen.Next(1, 11);
            fraction.SetTop(ranNum);

            ranNum = randomGen.Next(1,11);
            fraction.SetBottom(ranNum);

            string fractString = fraction.GetFractionString();
            double fractDecimal = fraction.GetDecimalValue();

            Console.WriteLine($"Fraction {i + 1}: String: {fractString}; Decimal: {fractDecimal}");
        }

    }
}