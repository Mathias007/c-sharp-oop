using System;
using System.Collections.Generic;

namespace HanoiAlgorithm
{
    abstract class TowersPainter : ITowersPainter
    {
        private static readonly int up = 6;
        private static readonly int down = 16;
        private static readonly int breakTime = 1000;
        private static readonly int jumpBetweenElements = 30;

        private static readonly ConsoleColor[] ColorsPallete =
        {
                ConsoleColor.Black,
                ConsoleColor.Magenta,
                ConsoleColor.Green,
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.DarkYellow,
                ConsoleColor.Green,
                ConsoleColor.Red,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta
        };

        private static void CreateTowerElement(string[] towerElement)
        {
            for (int i = 0; i <= 10; i++)
            {
                string space = new(' ', 10 - i);
                towerElement[i] = space + new string('\u2588', 2 * i + 1) + space;
            }
        }

        public static void StartProgramInConsole(string[] towerElement, int numberOfElements, Stack<int>[] towers)
        {
            CreateTowerElement(towerElement);

            Console.SetCursorPosition(0, up);
            for (int k = up; k <= down; k++)
                Console.WriteLine($" {towerElement[0]} {towerElement[0]} {towerElement[0]}");
            Console.Write(new string('\u2580', 3 * 21 + 2));

            for (int i = numberOfElements; i > 0; i--)
            {
                towers[0].Push(i);
                Console.SetCursorPosition(1, down + i - numberOfElements);
                Console.ForegroundColor = ColorsPallete[i];
                Console.Write(towerElement[i]);
            }

            Console.ForegroundColor = ColorsPallete[0];
            Console.SetCursorPosition(0, down + 2);
            Console.Write("Przerwanie wykonania programu: ESC");
            StopProgram(true);
        }

        public static void AnimateMovement(string[] towerElement, int startStack, int finalStack, Stack<int>[] towers, int movingElement)
        {
            int x = 21 * startStack + 1;
            int y = down - towers[startStack].Count;

            while (y > up)
            {
                Console.SetCursorPosition(x, y--);
                Console.Write(towerElement[0]);
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ColorsPallete[movingElement];
                Console.Write(ColorsPallete[movingElement]);
                Console.ForegroundColor = ColorsPallete[0];
                System.Threading.Thread.Sleep(jumpBetweenElements);
            }

            Console.SetCursorPosition(x, y);
            Console.Write(towerElement[0]);
            Console.SetCursorPosition(x = 21 * finalStack + 1, y);
            Console.ForegroundColor = ColorsPallete[movingElement];
            Console.Write(towerElement[movingElement]);
            Console.ForegroundColor = ColorsPallete[0];

            startStack = down - towers[finalStack].Count;

            while (y < startStack)
            {
                System.Threading.Thread.Sleep(jumpBetweenElements);
                Console.SetCursorPosition(x, y++);
                Console.Write(towerElement[0]);
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ColorsPallete[movingElement];
                Console.Write(towerElement[movingElement]);
                Console.ForegroundColor = ColorsPallete[0];
            }
        }

        public static void CleanElement(int element)
        {
            Console.SetCursorPosition(0, element);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, element);
        }

        public static void FinishVisualization()
        {
            CleanElement(down + 3);
            Console.CursorVisible = true;
            Environment.Exit(2);
        }

        public static void StopProgram(bool key)
        {
            if (key)
            {
                Console.SetCursorPosition(0, down + 3);
                Console.Write("Naciśnij dowolny klawisz...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    FinishVisualization();
                CleanElement(down + 3);
            }
            else
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    FinishVisualization();
                System.Threading.Thread.Sleep(breakTime);
            }
        }

        public static void ManageConsole(int elements, char stop)
        {
            Console.SetWindowSize(70, 22);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write($"Wieże Hanoi dla {elements} elementów \n-----------\n");
            Console.Write($"Zatrzymywanie jest {(stop.Equals('T') ? "WŁĄCZONE" : "WYŁĄCZONE")}");
        }
    }
}

