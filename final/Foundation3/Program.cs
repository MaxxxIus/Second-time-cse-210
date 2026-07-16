using System;

class Program
{
    static void Main(string[] args)
    {
        Address addre1 = new Address("123 45th St E", "Gerland", "Ohio", "United States", "97444");
        Lecture lect1 = new Lecture("How to be a Better Swimmer", addre1, "3/23/2026", "1:30 pm", "Mr. Swimmerman", 50, 
        "Come see Mr. Swimmerman share with YOU how you can become the best swimmer around!!!");

        Console.WriteLine("Standard Description:");
        lect1.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        lect1.DisplayShortDetails();
        Console.WriteLine();
        Console.WriteLine("Full Description:");
        lect1.DisplayFullDetails();
        Console.WriteLine();

        Address addre2 = new Address("4576 32nd Ave NW", "Minger", "Orstand", "France", "675444");
        Reception recept1 = new Reception("A Day to Remember", addre2, "4/26/2026", "6:00 pm",
        "Come Celebrate a day when two lives are changed forever.", "CallMoon@seeya.com");
        Console.WriteLine("Reception Test:");
        Console.WriteLine("Standard Description");
        recept1.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Short Description");
        recept1.DisplayShortDetail();
        Console.WriteLine();
        Console.WriteLine("Full Description");
        recept1.DisplayFullDetail();
        Console.WriteLine();

        Address addre3 = new Address("9876 Goo St", "Mikonta", "Minosoda", "Matincountey", "888888");
        Outdoor out1 = new Outdoor("GrillOut", addre3, "7/7/2027", "5:55 am",
        "Come compete for the title of best griller!!!", "We will have  tents up for Down pour");
        Console.WriteLine("Outdoor Event test");
        Console.WriteLine("Standard Descript");
        out1.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Short Description");
        out1.DisplayShortDetail();
        Console.WriteLine();
        Console.WriteLine("Full Description");
        out1.DisplayFullDetail();
    }
}