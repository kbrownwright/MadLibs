namespace MadLibs
{
    public class UserInterface
    {

        LibSheetTotal total = new LibSheetTotal();

        public void startGame()
        {
            Console.WriteLine("Welcome to BatLibs!");
            Console.WriteLine();
            GetActionChoice();

        }
        public void playGame()
        {
        total.GetUserLibChoice();
        }

        public void GetActionChoice()
        {
            string actionChoice = "";
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1) - Begin Game");
                Console.WriteLine("(2) - Get a Grammar Refresher");
                Console.WriteLine("(3) - Quit");
                actionChoice = Console.ReadLine();
                if (actionChoice == "1")
                {

                    playGame();

                    string finishedBatLib = total.GetFinalOutput();
                    Console.WriteLine("");
                    Console.WriteLine(total.parts[0]);
                    Console.WriteLine("");
                    Console.WriteLine(finishedBatLib);
                    Console.WriteLine("");
                }
                else if (actionChoice == "2")
                {
                    total.GrammarLesson();
                }
                else if (actionChoice != "3")
                {
                    Console.WriteLine("Please make a valid selection");
                }

            } while (actionChoice != "3");
        }
    }
}
