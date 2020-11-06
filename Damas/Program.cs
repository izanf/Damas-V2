using System;
using Figgle;

namespace Damas
{
    class Player
    {
        public int id;
        public string name;

        public Player(string playerName) {
            name = playerName;
        }
    }

    public enum Constants
    {
        BOARD_SIZE = 8,
    }
    
    public class Utils
    {
        public static void Welcome()
        {
            Console.WriteLine(FiggleFonts.Alligator.Render("| Damas V2 |"));
        }
    }

    public class Game
    {
        public static void Init()
        {
            string[,] board = new string[(int)Constants.BOARD_SIZE, (int)Constants.BOARD_SIZE];

            static void createBoard(string[,] board)
            {
                for (int i = 0; i < (int)Constants.BOARD_SIZE; i++)
                {
                    for (int j = 0; j < (int)Constants.BOARD_SIZE; j++)
                    {
                        if ((i + j) % 2 != 0)
                        {
                            board[i, j] = " ";
                            if (i >= 0 && i < 3)
                                board[i, j] = "X";
                            if (i >= 5 && i < 8)
                                board[i, j] = "O";
                        }
                        else
                        {
                            board[i, j] = "|";
                        }
                    }
                }
            }

            static void renderBoard(string[,] board)
            {
                for (int i = 0; i < (int)Constants.BOARD_SIZE; i++)
                {
                    for (int j = 0; j < (int)Constants.BOARD_SIZE; j++)
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            createBoard(board);
            renderBoard(board);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            //Utils myUtils = new Utils();
            //Utils.Welcome();

            Game game = new Game();
            Game.Init();
        }
    }
}
