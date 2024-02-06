namespace MadLibs
{
    public class LibSheetTotal
    {
        int numberOfSheets = 4;
        string finalOutput = "";
        public string[]? parts;
        public int userChoice = 0;
        public void GetUserChoice()

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
            while (!(userChoice >= 1 && userChoice <= numberOfSheets));
        }
        public string GetUserWord(int i)
        {
            Console.WriteLine("Please enter a/an " + parts[i] + ": ");
            string newWord = Console.ReadLine();
            return newWord;
        }
        public void GetUserLib()
        {
            {
                string folder = "C:\\Users\\chaot\\source\\repos\\testingCSharp\\";
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
                            line = sr.ReadLine();
                            i++;
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
        }
        public void ConstructOutput(string[] parts)
        {
            for (int i = 2; i < parts.Length; i++)

                if (i % 2 == 0)
                {
                    {
                        finalOutput += parts[i];
                    }
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
    }

}

