namespace MadLibs
{
    public class UserInterface
    {

        LibSheetTotal total = new LibSheetTotal();

        public void startGame()
        {
            Console.WriteLine("Welcome to BatLibs!");
            Console.WriteLine();

            total.GetUserChoice();

            Console.WriteLine("");
            Console.WriteLine("Ready for your BatLib?");
            Console.WriteLine("");
            Console.WriteLine(total.parts[0]);
            Console.WriteLine("");

            string finishedBatLib = total.GetFinalOutput();
            Console.WriteLine(finishedBatLib);
            Console.WriteLine("");
        }


    }
}
