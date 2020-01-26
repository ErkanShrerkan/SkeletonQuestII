using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton_Quest_II
{
    class Player : Character
    {
        public Player()
        {
            directions = new bool[] { up = true, down = true, left = true, right = true };
            name = "Player";
            hp = 100;
        }

        public void PlayerController(char[,] tiles)
        {
            var key = Console.ReadKey(true);

            directions = CheckValidDirections(tiles);

            if (key.Key == ConsoleKey.RightArrow && directions[3])
            {
                Walk(1, 0, tiles);
            }
            if (key.Key == ConsoleKey.LeftArrow && directions[2])
            {
                Walk(-1, 0, tiles);
            }
            if (key.Key == ConsoleKey.UpArrow && directions[0])
            {
                Walk(-1, 1, tiles);
            }
            if (key.Key == ConsoleKey.DownArrow && directions[1])
            {
                Walk(1, 1, tiles);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }

        void Walk(int direction, int axis, char[,] tiles)
        {
            Game.ColorMap(tiles, Pos[0], Pos[1], "update");
            Pos[axis] += direction;
        }

        bool[] CheckValidDirections(char[,] tiles)
        {
            if (tiles[Pos[0] - 1, Pos[1]] == '#')
            {
                directions[2] = false;
            }
            else if (tiles[Pos[0] - 1, Pos[1]] != '#')
            {
                directions[2] = true;
            }
            if (tiles[Pos[0] + 1, Pos[1]] == '#')
            {
                directions[3] = false;
            }
            else if (tiles[Pos[0] + 1, Pos[1]] != '#')
            {
                directions[3] = true;
            }
            if (tiles[Pos[0], Pos[1] - 1] == '#')
            {
                directions[0] = false;
            }
            else if (tiles[Pos[0], Pos[1] - 1] != '#')
            {
                directions[0] = true;
            }
            if (tiles[Pos[0], Pos[1] + 1] == '#')
            {
                directions[1] = false;
            }
            else if (tiles[Pos[0], Pos[1] + 1] != '#')
            {
                directions[1] = true;
            }
            return directions;
        }
    }
}
