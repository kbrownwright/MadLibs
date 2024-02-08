namespace MadLibs
{
    public class LibSheetTotal
    {
        int numberOfSheets = 5;
        string finalOutput = "";
        public string[]? parts;
        public int userChoice = 0;



        public void GetUserLibChoice()
        {
            do
            {
                Console.WriteLine($"Choose a Mad Lib (1-{numberOfSheets})");
                string userChoiceTemp = (Console.ReadLine());
                if (int.TryParse(userChoiceTemp, out userChoice) && userChoice >= 1 && userChoice <= numberOfSheets)
                {
                    GetUserLib();
                }
                else
                {
                    Console.WriteLine("Please choose a valid selection");
                }
            }
            while (!(userChoice >= 1) && !(userChoice <= numberOfSheets));
        }
        public string GetUserWord(int i)
        {
            Console.Write("Please enter " + parts[i] + ": ");
            string newWord = Console.ReadLine();
            return newWord;
        }
        public void GetUserLib()
        {
            finalOutput = "";
           
                string folder = "C:\\Users\\chaot\\OneDrive\\Desktop\\Workspace\\";
                string fileName = "MadLibs\\ListOfLibs.txt";
                string INPUTFILE = Path.Combine(folder, fileName);
                string title = "";

                try
                {
                    using (StreamReader sr = new StreamReader(INPUTFILE))
                    {
                        string line = "";
                        int i = 0;
                        while (!sr.EndOfStream)
                        {
                        i++;

                        line = sr.ReadLine();
                            if (i == userChoice)
                            {
                                try
                                {
                                    parts = line.Split("|");
                                    title = parts[0];
                                    ConstructOutput(parts);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Oops! Something went wrong construction your BatLib");
                                }
                            }
                            else
                            {

                            }

                        }
                    }
                }
                catch (Exception ex1)
                {
                    Console.WriteLine("Oops! Something went wrong getting your BatLib");
                }
            
        }
        public void ConstructOutput(string[] parts)
        {
            for (int i = 2; i < parts.Length; i++)

                if (i % 2 == 0)
                {                   
                        finalOutput += parts[i];                   
                }
                else if (parts[i] != null)
                {
                    string replacedWord = GetUserWord(i);
                    finalOutput += replacedWord;
                }
        }
        public string GetFinalOutput()
        {
            return finalOutput;
        }

        public void GrammarLesson()
        {
            //get verb/adjective/etc definitions
            Console.WriteLine("");
            Console.WriteLine("A NOUN is a person, place, or thing.  (Fox, Dogs)");
            Console.WriteLine("An ADJECTIVE is a word that describes a noun. (Brown, Lazy)");
            Console.WriteLine("A VERB is an action word. (Jumped)");
            Console.WriteLine("An ADVERB is a word that describes a verb. (Quickly)");
            Console.WriteLine("");
            Console.WriteLine("The Brown Fox Quickly Jumped Over the Lazy Dogs");
            Console.WriteLine("");
        }
    }

}

