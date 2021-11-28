using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[8, 8];
            int water = 0;
            int ship = 1;
            int hit = 7;
            int miss = 8;
            int shotX = 0;
            int shotY = 0;


            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    grid[y, x] = water;
                }
            }

            grid[2, 5] = ship;
            grid[2, 6] = ship;
            grid[2, 7] = ship;

            grid[5, 5] = ship;
            grid[5, 6] = ship;

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                Console.WriteLine("      [1][2][3][4][5][6][7][8]");
                Console.WriteLine("      ________________________");
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(" [" + (y + 1) + "] |");
                    for (int x = 0; x < 8; x++)
                    {
                        if (grid[y, x] == miss)
                        {
                            Console.Write("[O]");
                        }
                        else if (grid[y, x] == water)
                        {
                            Console.Write("[~]");
                        }
                        else if (grid[y, x] == hit)
                        {
                            Console.Write("[X]");
                        }
                        else if (grid[y, x] == ship)
                        {
                            Console.Write("[~]");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Give me an X coordinate [1-8]:");   //Asks user input for x
                shotX = Convert.ToInt32(Console.ReadLine()) - 1;    //Converts user input to integer, and stores as shotX

                Console.WriteLine("Give me a Y coordinate  [1-8]:");    //Asks user input for y
                shotY = Convert.ToInt32(Console.ReadLine()) - 1;

                if (grid[shotY, shotX] == ship)
                {
                    Console.WriteLine("HIT!");
                    grid[shotY, shotX] = hit;
                }
                else
                {
                    Console.WriteLine("Miss!");
                    grid[shotY, shotX] = miss;
                }

            }
        }
    }
}
