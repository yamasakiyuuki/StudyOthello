using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        public static bool isYour = true;

        /// <summary>
        /// 石の配置処理の関数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Box_PictureBoxExClick(int x, int y)
        {
            //すでに石が配置されている場合関数を終了
            if (osero.Form1.StonePosition[x, y].StoneColor == StoneColor.Black ||
                osero.Form1.StonePosition[x, y].StoneColor == StoneColor.White)
                return;
            
            // 相手の手番ならば配置せずに関数を終了
            if (!isYour)
                return;

            //ヒント表示を非表示にする
            var grayStones = osero.Form1.StonePosition.Cast<Stone>();
            grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
            var hintPositions = grayStones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.None;

            // 配置可能な場所か調べる
            List<Stone> stones = GetRevarseStones(x, y, StoneColor.Black);

            // 配置可能であれば石を置き、挟んだ石を反転させる
            if (stones.Count != 0)
            {
                osero.Form1.StonePosition[x, y].StoneColor = StoneColor.Black;
                stones.Select(xx => xx.StoneColor = StoneColor.Black).ToList();
                StoneNumber();
                isYour = false;
                osero.Form1.BoardStatus[osero.Form1.num++] = osero.Common.Form1.BoardInf(osero.Form1.StonePosition[x, y], stones);

                if (osero.Form1.num == 0)
                {
                    
                    return;
                }
                if (isYour)
                    return;

                //相手の手番の処理を実行
                EnemyThink();
                StoneNumber();
            }
        }
    }
}
