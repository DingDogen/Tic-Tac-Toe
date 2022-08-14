namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameField playField = new GameField();
            Actions action = new Actions();
            while (true)
            {
                action.ChooseMove();
                playField.PrintField();
                playField.FillCell(action.ChooseLabel(), action.ChooseCell());
                Console.Clear();
                if (playField.WinCheck())
                {
                    playField.PrintField();
                    break;
                }

                if (playField.moves == 9)
                {
                    playField.PrintField();
                    Console.WriteLine("No one can win!\nGame over!");
                    break;
                }
            }
        }
    }
}