using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class Chess
    {
        private bool[,] chessBoard;
        private int MAX_X = 5;
        private int MAX_Y = 5;
        private int number;
        private Grid[] path;
        private Direction[] theDir = new Direction[]
        {       new Direction(2, -1), new Direction(2, 1),
                new Direction(1, 2), new Direction(-1, 2),
                new Direction(-2, 1), new Direction(-2, -1),
                new Direction(-1, -2), new Direction(1, -2)
        };
        public Chess(int x, int y)
        {
            MAX_X = x;
            MAX_Y = y;
            number = MAX_X * MAX_Y;
            chessBoard = new bool[MAX_X, MAX_Y];
            for (int i = 0; i < MAX_X; i++)
                for (int j = 0; j < MAX_Y; j++)
                    chessBoard[i, j] = false;
            path = new Grid[number];
        }
        public bool isValid(Grid theGrid)
        {
            if (theGrid.x >= 0 && theGrid.y >= 0 && theGrid.x < MAX_X && theGrid.y < MAX_Y)
                return true;
            return false;
        }
        public Grid getNextUnVisitedLattice(int f, Grid grd)
        {
            for (int i = f; i < theDir.Length; i++)
            {
                Grid temp = grd.getNextGrid(i, theDir[i]);
                if (isValid(temp))
                {
                    if (!chessBoard[temp.x, temp.y])
                    {
                        return temp;
                    }
                }
            }
            return null;
        }
        public void disPlayKnightTour()
        {
            for (int i = 0; i < MAX_X; i++)
            { 
                for (int k = 0; k < MAX_Y; k++)
                {
                    chessBoard[i, k] = false;
                }
            }
            for (int i = 0; i < path.Length; i++)
            { 
                Grid temp = path[i];
                chessBoard[temp.x, temp.y] = true;
                disPlayChessBoard();
            }
        }
        public void disPlayChessBoard()
        {
            Console.Write("  ");
            for (int i = 0; i < MAX_Y; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            for (int i = 0; i < MAX_X; i++)
            {
                Console.Write(" " + i);
                for (int j = 0; j < MAX_Y; j++)
                {
                    if (chessBoard[i, j] == false)
                    {
                        Console.Write(" □");
                    }
                    else
                    {
                        Console.Write(" ■");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void knightTour()
        {
            StackX path = new StackX();
            path.push(new Grid(-1, 0, 0));
            number--;
            chessBoard[0, 0] = true;
            // disPlayChessBoard();
            int f = 0;

            while (!path.isEmpty())
            {
                Grid temp = getNextUnVisitedLattice(f, path.peek());
                if (temp == null)
                {
                    Grid l = path.pop();
                    chessBoard[l.x, l.y] = false;
                    f = l.z + 1;
                    number++;
                }
                else
                {
                    chessBoard[temp.x, temp.y] = true;
                    path.push(temp);
                    f = 0;
                    number--;
                }

                if (number == 0)
                {
                    int j = this.path.Length - 1;
                    while (!path.isEmpty())
                    {
                        this.path[j--] = path.pop();

                    }
                    disPlayKnightTour();
                    Console.WriteLine("success!");
                    return;
                }
            }
            Console.WriteLine("failure!");
        }
    }
}

