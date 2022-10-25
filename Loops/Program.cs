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

        static int maxX = 60;
        static int maxY = 30;
        static void Main(string[] args)
        {
            gameOver = false;
            x = 5;
            y = 5;

            while (gameOver == false)
            {
                Console.Clear();
                PlayerDraw(x, y);
                PlayerUpdate();
            }



        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("0");
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
                    if (y == 0)
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
                    if (x == 0)
                    {
                        break;
                    }
                    else
                    {
                        x--;
                        break;
                    }

                case ConsoleKey.D:
                    if (x >= maxX)
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
