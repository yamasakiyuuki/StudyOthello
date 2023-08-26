using System.Collections.Generic;
using System.Windows.Forms;

namespace osero.Common
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 石の反転処理の関数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="stoneColor"></param>
        /// <returns></returns>
        static List<Stone> GetRevarseStones(int x, int y, StoneColor stoneColor)
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
