using System;
using System.Linq;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        /// <summary>
        /// ゲーム終了処理の関数
        /// </summary>
        public static void OnGameset()
        {
            var stones = osero.Form1.StonePosition.Cast<Stone>();

            //盤面の石の数を取得
            int blackCount = stones.Count(xx => xx.StoneColor == StoneColor.Black);
            int whiteCount = stones.Count(xx => xx.StoneColor == StoneColor.White);

            string str = "";
            //対戦結果の出力
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
