using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1
    {
        /// <summary>
        /// 降参を行う関数
        /// </summary>
        public static void Surrender()
        {
            DialogResult result = MessageBox.Show(
                "降参しますか?", "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
            {
                return;
            }

            //降参後に打てないようにする
            isYour = false;

            string str = "";
            str = "あなたの負けです";
            MessageBox.Show(str);
            return;
        }
    }
}
    

