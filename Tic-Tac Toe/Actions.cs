namespace Tic_Tac_Toe
{
    internal class Actions
    {
        byte chooseNumber = 0;
        public void ChooseMove()
        {
            if (this.chooseNumber % 2 == 0)
            {
                Console.WriteLine("Krestiki:");
            }
            else
            {
                Console.WriteLine("Noliki:");

            }

            this.chooseNumber++;
        }

        public char ChooseLabel()
        {
            if (this.chooseNumber % 2 == 1)
            {
                return 'X';
            }

            else
            {
                return 'O';
            }
        }

        public int[] ChooseCell()
        {
            while (true)
            {
                string? key = Console.ReadLine();
                switch (key[0])
                {
                    case '7':
                        {
                            return new int[] { 0, 0 };
                        }
                    case '8':
                        {
                            return new int[] { 0, 1 };
                        }

                    case '9':
                        {
                            return new int[] { 0, 2 };
                        }

                    case '4':
                        {
                            return new int[] { 1, 0 };
                        }

                    case '5':
                        {
                            return new int[] { 1, 1 };
                        }

                    case '6':
                        {
                            return new int[] { 1, 2 };
                        }

                    case '1':
                        {
                            return new int[] { 2, 0 };
                        }

                    case '2':
                        {
                            return new int[] { 2, 1 };
                        }

                    case '3':
                        {
                            return new int[] { 2, 2 };
                        }

                    default:
                        {
                            Console.WriteLine("Wrong value"); continue;
                        }
                }
            }
        }

    }
}
