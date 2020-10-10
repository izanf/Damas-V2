using System;
using Figgle;

namespace Damas
{
    public class Utils
    {
        public static void Welcome()
        {
            Console.WriteLine(FiggleFonts.Alligator.Render("| Damas V2 |"));
        }
    }

    public class Game
    {
        public static void Tab()
        {
            string[,] table = new string[,] { {"A", "B" }, { "C", "D" } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(table[i, j] + " ");
                }

                if (i == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    class MainClass
    {
        public static void Main()
        {
            //Utils myUtils = new Utils();
            //Utils.Welcome();

            Game game = new Game();
            Game.Tab();
        }
    }
}
