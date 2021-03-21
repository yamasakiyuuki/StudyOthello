using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    public partial class Form1 : Form
    {
        List<Stone> GetRevarseStones(int x, int y, StoneColor stoneColor)
        {
            List<Stone> stones = new List<Stone>();
            stones.AddRange(GetReverseOnPutUp(x, y, stoneColor)); // 上方向に挟めているものを取得
            stones.AddRange(GetReverseOnPutDown(x, y, stoneColor)); // 下
            stones.AddRange(GetReverseOnPutLeft(x, y, stoneColor)); // 左
            stones.AddRange(GetReverseOnPutRight(x, y, stoneColor)); // 右
            stones.AddRange(GetReverseOnPutLeftTop(x, y, stoneColor)); // 左上
            stones.AddRange(GetReverseOnPutLeftDown(x, y, stoneColor)); // 左下
            stones.AddRange(GetReverseOnPutRightTop(x, y, stoneColor)); // 右上
            stones.AddRange(GetReverseOnPutRightDown(x, y, stoneColor)); // 右下

            return stones;
        }
    }
}
