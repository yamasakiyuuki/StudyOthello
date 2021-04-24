using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1
    {
        public static void Surrender()
        {
            //var stones = osero.Form1.StonePosition.Cast<Stone>();

            //int blackCount = stones.Count(xx => xx.StoneColor == StoneColor.Black);
            //int whiteCount = stones.Count(xx => xx.StoneColor == StoneColor.White);

            isYour = false;
            string str = "";
            str = "あなたの負けです";
            MessageBox.Show(str);
            return;
        }
    }
}
    

