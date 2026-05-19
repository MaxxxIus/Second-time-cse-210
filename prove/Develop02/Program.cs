using System;
using System.IO;
/*
 class team assignment excersise: https://byui-cse.github.io/cse210-course-2023/unit02/design.html :for help working out the outline of the project and a video example
 class project assignment: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html :for requirments and video example
 google AI overview: prompt: "C# how to write comments" :this one was just to know how you comment out multiple lines
 google AI overveiw: prompt: "C:\Users\hatin\OneDrive\Desktop\Prog.Projects\ecs 210\Second-time-cse-210\prove\Develop02\Entry.cs(12,6): error CS1513: } expected [C:\Users\hatin\OneDrive\Desktop\Prog.Projects\ecs 210\Second-time-cse-210\prove\Develop02\Develop02.csproj]" 
    was worried I had broke the files, so i copy and pasted the error code into google, said it was probably just a miss placed curly bracket,
class assignment: "https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html" :had to go back and remember how to set up a random number generator
class assignment for help on the load and save section: "https://byui-cse.github.io/cse210-course-2023/unit02/develop.html"
*/

// added feature: I made it so you could use ether numbers or a word to select an option. It also doesnt matter the caps of the word when selecting

class Program
{
    static void Main(string[] args)
    {
        // set up prompt generator
        PromptGenerator AMBpromptGen = new PromptGenerator();
        AMBpromptGen.AddPrompt("What was the most intresting person you meet today?");
        AMBpromptGen.AddPrompt("What was one blessing you had happen to you?");
        AMBpromptGen.AddPrompt("What was one accomplishment you acheived today?");
        AMBpromptGen.AddPrompt("What is one memory from today you will hold onto?");
        AMBpromptGen.AddPrompt("How have you improved your mindset from today?");

        //set up journal
        Journal AMBactiveJournal = new Journal();

        //begin program loop 
        string AMBchoice = "";
        string AMBlower = "";
        while (!(AMBchoice == "5" || AMBlower == "end"))
        {
            Console.WriteLine("Choose from the following: ");
            Console.WriteLine("1. WRITE an entry");
            Console.WriteLine("2. DISPLAY Journal entries");
            Console.WriteLine("3. SAVE Journal");
            Console.WriteLine("4. LOAD Journal");
            Console.WriteLine("5. END");
            Console.Write("Please enter in your choice: ");
            AMBchoice = Console.ReadLine();
            AMBlower = AMBchoice.ToLower();

            //processes choice
            if (AMBchoice == "1" || AMBlower == "write")
            {
                // Writes a new entry and adds it to the journal
                //get date
                DateTime AMBcurrentTime = DateTime.Now;
                string AMBdateText = AMBcurrentTime.ToShortDateString();

                //asks prompts
                string AMBcurrentPrompt = AMBpromptGen.GivePrompt();
                Console.WriteLine($"Current Prompt: {AMBcurrentPrompt}");

                //gets prompt from user
                Console.Write("please write your response: ");
                string AMBuserResponse = Console.ReadLine();

                //creates entry
                Entry currentEntry  = new Entry();
                currentEntry._AMBdate = AMBdateText;
                currentEntry._AMBprompt = AMBcurrentPrompt;
                currentEntry._AMBresponse = AMBuserResponse;

                AMBactiveJournal.AddEntry(currentEntry);


            } else if (AMBchoice == "2" || AMBlower == "display")
            {
                //displays all entrys in the current journal
                AMBactiveJournal.DisplayEntrys();

            }else if (AMBchoice == "3" || AMBlower == "save")
            {
                //saves the journal to a .txt file
                //prompt user for text file name
                Console.Write("What is the name of the text file: ");
                string txtFile = Console.ReadLine();

                //create file
                List<string> txtDataBase = AMBactiveJournal.ConvertToTXTFormat();
                using (StreamWriter outputFile = new StreamWriter(txtFile))
                {
                    foreach (string line in txtDataBase)
                    {
                        outputFile.WriteLine(line);
                    }
                }
                Console.WriteLine("Save successful");
            }else if (AMBchoice == "4" || AMBlower == "load")
            {
                //loads the contents from a .txt file onto the active journal
                //get name of file from user 
                Console.Write("What is the name of the file you wish to load: ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                //translates file into journal entries
                foreach (string line in lines)
                {
                    string[] parts = line.Split("<||>");
                    Entry AMBentry = new Entry();
                    AMBentry._AMBdate = parts[0];
                    AMBentry._AMBprompt = parts[1];
                    AMBentry._AMBresponse = parts[2];

                    AMBactiveJournal.AddEntry(AMBentry);
                }

                Console.WriteLine("Load successful!!!");
            } else if (!(AMBchoice == "5" || AMBlower == "end"))
            {
                //invalid response catch
              Console.WriteLine("Invalid Response. Please choose a proper option!!!");
            }
        }

    }
}