using System;
using System.Linq;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        /// <summary>
        /// 配置されている黒白の石の数を表示する関数
        /// </summary>
        public static void StoneNumber()
        { 
            var stones = osero.Form1.StonePosition.Cast<Stone>();

            int blackCount = stones.Count(xx => xx.StoneColor == StoneColor.Black);
            int whiteCount = stones.Count(xx => xx.StoneColor == StoneColor.White);

            string StoneNo = "";
            StoneNo = String.Format("黒:{0}\n白:{1} ", blackCount, whiteCount);
            osero.Form1.komaNumber.Text = StoneNo;
        }
    }
}
