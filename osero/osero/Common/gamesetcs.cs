using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        public static void OnGameset()
        {
            var stones = osero.Form1.StonePosition.Cast<Stone>();

            int blackCount = stones.Count(xx => xx.StoneColor == StoneColor.Black);
            int whiteCount = stones.Count(xx => xx.StoneColor == StoneColor.White);

            string str = "";
            if (blackCount != whiteCount)
            {
                string winner = blackCount > whiteCount ? "黒" : "白";
                str = String.Format("終局しました。{0} 対 {1} で {2} の勝ちです。", blackCount, whiteCount, winner);
            }
            else
            {
                str = String.Format("終局しました。{0} 対 {1} で 引き分けです。", blackCount, whiteCount);
            }
            MessageBox.Show(str);
            return;
        }
    }
}
