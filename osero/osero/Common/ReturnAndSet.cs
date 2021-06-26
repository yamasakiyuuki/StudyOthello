using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        public static bool isYour = true;
        async public static void Box_PictureBoxExClick(int x, int y)
        {
            if (osero.Form1.StonePosition[x, y].StoneColor == StoneColor.Black ||
                osero.Form1.StonePosition[x, y].StoneColor == StoneColor.White)
                return;
            
            // 自分の手番か確認する
            if (!isYour)
                return;

            var grayStones = osero.Form1.StonePosition.Cast<Stone>();
            grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
            var hintPositions = grayStones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.None;
            // 着手可能な場所か調べる
            List<Stone> stones = GetRevarseStones(x, y, StoneColor.Black);

            // 着手可能であれば石を置き、挟んだ石をひっくり返す
            if (stones.Count != 0)
            {
                ////ヒントを元に戻す
                //var grayStones = osero.Form1.StonePosition.Cast<Stone>();
                //grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
                //var hintPositions = grayStones.ToList();
                //foreach (Stone stone in hintPositions)
                //    stone.StoneColor = StoneColor.None;
                osero.Form1.StonePosition[x, y].StoneColor = StoneColor.Black;
                stones.Select(xx => xx.StoneColor = StoneColor.Black).ToList();
                StoneNumber();
                isYour = false;
                osero.Form1.BoardStatus[osero.Form1.num++] = osero.Common.Form1.BoardInf(osero.Form1.StonePosition[x, y], stones);

                // コンピュータの手番（次回）
                await Task.Delay(1000);
                grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
                hintPositions = grayStones.ToList();
                foreach (Stone stone1 in hintPositions)
                    stone1.StoneColor = StoneColor.None;
                if (isYour)
                    return;
                EnemyThink();
                StoneNumber();
                
                //grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
                //foreach (Stone stone1 in hintPositions)
                //    stone1.StoneColor = StoneColor.None;
            }
            else { }
                //toolStripStatusLabel1.Text = "ここには打てません";
        }
    }
}
