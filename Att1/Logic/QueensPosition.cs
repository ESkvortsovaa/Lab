using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class QueensPosition
    {
        List<Position> list;
        private bool SetPosition(bool[,] pole, int N)
        {
            if(N==0)
            {
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        if (!pole[i, j])
                            return false;
                return true;
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if(!pole[i,j])
                    {
                        if (SetPosition(Copy(pole, i, j), N - 1))
                        {
                            list.Add(new Position(i, j));
                            return true;
                        }
                    }
                }
            return false;
        }
        private bool[,] Copy(bool[,] first, int x, int y)
        {
            bool[,] second = new bool[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (first[i, j] || i == x || j == y || Math.Abs(x - i) == Math.Abs(y - j))
                        second[i, j] = true;
            return second;
        }
        public List<Position> GetPositions()
        {
            list = new List<Position>();
            SetPosition(new bool[8, 8], 5);
            return list;
        }
        public List<Position> GetPositions(Position pos,out bool res)
        {
            list = new List<Position>() { pos };
            res = SetPosition(Copy(new bool[8, 8],pos.X,pos.Y), 4);
            return list;
        }

    }
}
