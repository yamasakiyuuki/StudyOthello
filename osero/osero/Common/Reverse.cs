using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    public partial class Form1 : Form
    {
        List<Stone> GetReverseOnPutUp(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (y - 1 < 0)
                return stones;

            var s = osero.Form1.StonePosition[x, y - 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (y - 1 - i < 0)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x, y - 1 - i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;
                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutDown(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (y + 1 > 7)
                return stones;

            var s = osero.Form1.StonePosition[x, y + 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (y + 1 + i > 7)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x, y + 1 + i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;
                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutLeft(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x - 1 < 0)
                return stones;

            var s = osero.Form1.StonePosition[x - 1, y];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x - 1 - i < 0)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x - 1 - i, y];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;
                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutRight(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x + 1 > 7)
                return stones;

            var s = osero.Form1.StonePosition[x + 1, y];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x + 1 + i > 7)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x + 1 + i, y];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;
                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutLeftTop(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x - 1 < 0)
                return stones;
            if (y - 1 < 0)
                return stones;

            var s = osero.Form1.StonePosition[x - 1, y - 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x - 1 - i < 0)
                    return new List<Stone>();

                if (y - 1 - i < 0)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x - 1 - i, y - 1 - i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;

                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutRightTop(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x + 1 > 7)
                return stones;
            if (y - 1 < 0)
                return stones;

            var s = osero.Form1.StonePosition[x + 1, y - 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x + 1 + i > 7)
                    return new List<Stone>();

                if (y - 1 - i < 0)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x + 1 + i, y - 1 - i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;

                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutRightDown(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x + 1 > 7)
                return stones;
            if (y + 1 > 7)
                return stones;

            var s = osero.Form1.StonePosition[x + 1, y + 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x + 1 + i > 7)
                    return new List<Stone>();

                if (y + 1 + i > 7)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x + 1 + i, y + 1 + i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;

                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }

        List<Stone> GetReverseOnPutLeftDown(int x, int y, StoneColor color)
        {
            List<Stone> stones = new List<Stone>();
            StoneColor enemyColor = StoneColor.None;
            if (color == StoneColor.Black)
                enemyColor = StoneColor.White;
            else
                enemyColor = StoneColor.Black;

            if (x - 1 < 0)
                return stones;
            if (y + 1 > 7)
                return stones;

            var s = osero.Form1.StonePosition[x - 1, y + 1];
            if (s.StoneColor == color || s.StoneColor == StoneColor.None)
                return stones;

            stones.Add(s);

            for (int i = 0; ; i++)
            {
                if (x - 1 - i < 0)
                    return new List<Stone>();

                if (y + 1 + i > 7)
                    return new List<Stone>();

                var s1 = osero.Form1.StonePosition[x - 1 - i, y + 1 + i];
                if (s1.StoneColor == enemyColor)
                {
                    stones.Add(s1);
                    continue;
                }
                if (s1.StoneColor == color)
                    return stones;

                if (s1.StoneColor == StoneColor.None)
                    return new List<Stone>();
            }
        }
    }
}
