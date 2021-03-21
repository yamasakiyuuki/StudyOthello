using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    public partial class Form1 : Form
    {
        bool isYour = true;
        async private void Box_PictureBoxExClick(int x, int y)
        {
            // 自分の手番か確認する
            if (!isYour)
                return;

            // 着手可能な場所か調べる
            List<Stone> stones = GetRevarseStones(x, y, StoneColor.Black);

            // 着手可能であれば石を置き、挟んだ石をひっくり返す
            if (stones.Count != 0)
            {
                osero.Form1.StonePosition[x, y].StoneColor = StoneColor.Black;
                stones.Select(xx => xx.StoneColor = StoneColor.Black).ToList();
                isYour = false;

                // コンピュータの手番（次回）
            }
            else { }
                //toolStripStatusLabel1.Text = "ここには打てません";
        }
    }
}
