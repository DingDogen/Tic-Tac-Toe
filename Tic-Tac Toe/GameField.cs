using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class GameField
    {
        public char[,] field; // изначальное поле, пока нету игры
        public int moves = 0;
        public GameField() // инициализатор поля
        {
            this.field = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        }

        public void FillCell(char symbol, int[] coordinates)
        {
            this.field[coordinates[0],coordinates[1]] = symbol;
            this.moves++;
        }

        public void PrintField()
        {
            //for (int row = 0, i = 0; row < 7; row++)
            //{
            //    if ((row + 3) % 2 == 1)
            //    {
            //        Console.WriteLine("+—+—+—+");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"|{this.field[i, 0]}|{this.field[i, 1]}|{this.field[i, 2]}|");
            //        i++;
            //    }
            //}

            for (int row = 0, i = 0; row < 3; row++)
            {
                Console.WriteLine($"|{this.field[i, 0]}|{this.field[i, 1]}|{this.field[i, 2]}|");
                i++;
            }
        }

        public bool WinCheck()
        {
            #region Cross
            if (string.Concat( this.field[0,0], this.field[0,1], this.field[0,2]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;
            }
            if (string.Concat(this.field[1, 0], this.field[1, 1], this.field[1, 2]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[2, 0], this.field[2, 1], this.field[2, 2]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[0, 0], this.field[1, 0], this.field[2, 0]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[0, 1], this.field[1, 1], this.field[2, 1]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[0, 2], this.field[1, 2], this.field[2, 2]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[0, 0], this.field[1, 1], this.field[2, 2]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            if (string.Concat(this.field[0, 2], this.field[1, 1], this.field[2, 0]) == "XXX")
            {
                Console.WriteLine("Krestiki win!");
                return true;

            }
            #endregion
            #region Zero
            if (string.Concat(this.field[0, 0], this.field[0, 1], this.field[0, 2]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[1, 0], this.field[1, 1], this.field[1, 2]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[2, 0], this.field[2, 1], this.field[2, 2]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[0, 0], this.field[1, 0], this.field[2, 0]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[0, 1], this.field[1, 1], this.field[2, 1]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[0, 2], this.field[1, 2], this.field[2, 2]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[0, 0], this.field[1, 1], this.field[2, 2]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            if (string.Concat(this.field[0, 2], this.field[1, 1], this.field[2, 0]) == "OOO")
            {
                Console.WriteLine("Noliki win!");
                return true;

            }
            return false;
            #endregion

        }

    }
}
