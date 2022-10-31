using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {



        static bool gameOver;
        static ConsoleKeyInfo choice;

        static int x;
        static int y;

        static string character;

        static int maxX = 30;
        static int maxY = 10;
        static void Main(string[] args)
        {
            gameOver = false;
            x = 5;
            y = 5;
            character = "0";

            while (gameOver == false)
            {
                Console.Clear();
                DrawMap();
                PlayerDraw(x, y);
                PlayerUpdate();
            }
        }

        static void DrawMap()
        {
            string border = "|";
            int count = 0;

            Console.Write(".");
            while (count <= (maxX - 2))
            {
                Console.Write("-");
                count = count + 1;
            }

            Console.WriteLine(".");

            count = 0;

            while (count < maxY)
            {
                Console.WriteLine(border.PadRight(maxX) + border);
                count = count + 1;
            }

            Console.Write("'");

            count = 0;

            while (count <= (maxX - 2))
            {
                Console.Write("-");
                count = count + 1;
            }

            Console.WriteLine("'");
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(character);
        }

        static void PlayerUpdate()
        {
            choice = Console.ReadKey(true);
            switch(choice.Key)
            {
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;

                case ConsoleKey.W:
                    if (y == 1)
                    {
                        break;
                    }
                    else
                    {
                        y--;
                        break;
                    }

                case ConsoleKey.S:
                    if (y >= maxY)
                    {
                        break;
                    }
                    else
                    {
                        y++;
                        break;
                    }

                case ConsoleKey.A:
                    if (x == 1)
                    {
                        break;
                    }
                    else
                    {
                        x--;
                        break;
                    }

                case ConsoleKey.D:
                    if (x >= (maxX -1))
                    {
                        break;
                    }
                    else
                    {
                        x++;
                        break;
                    }
            }
        }
    }
}
