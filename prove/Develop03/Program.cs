using System;

class Program
{
    static void Main(string[] args)
    {
        string AMBref = "Luke 1:1-4";
        string AMBscript = "Forasmuch as many have taken in hand to set forth in order a declaration of those things which are most surely believed among us Even as they delivered them unto us which from the beginning were eyewitnesses and ministers of the word It seemed good to me also having had perfect understanding of all things from the very first to write unto thee in order most excellent Theophilus That thou mightest know the certainty of those things wherein thou hast been instructed";
        Scripture AMBscripture = new Scripture(AMBref, AMBscript);
        string AMBanswer;
        do
        {
            Console.WriteLine(AMBscripture.GetPassage());
            Console.Write("Hit enter to continue, or type end to finish: ");
            AMBanswer = Console.ReadLine();
            if (AMBscripture.CheckHiddenAll() == false)
            {
                AMBscripture.HideRandom();
                Console.Clear();
            } else {
                Console.WriteLine("Thats all!!");
                AMBanswer = "end";
            }
            
        } while (AMBanswer.ToLower() != "end");
    }
}