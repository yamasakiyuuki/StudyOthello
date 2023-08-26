using System;
using System.Drawing;
using System.Windows.Forms;

namespace osero.Common
{
    /// <summary>
    /// 盤面のマスのクラス
    /// </summary>
    public class Stone : PictureBox
    {
        StoneColor stoneColor = StoneColor.None;
        public int Colum
        {
            protected set;
            get;
        } = 0;
        public int Row
        {
            protected set;
            get;
        } = 0;

        public Stone(int colum, int row)
        {
            Colum = colum;
            Row = row;

            Click += Stone_Click;
        }

        public delegate void StoneClickHandler(int x, int y);
        public event StoneClickHandler StoneClick;
        public void Stone_Click(object sender, EventArgs e)
        {
            StoneClick?.Invoke(Colum, Row);
        }

        public StoneColor StoneColor
        {
            get { return stoneColor; }
            set
            {
                stoneColor = value;

                if (value == StoneColor.Black)
                    BackColor = Color.Black;
                if (value == StoneColor.White)
                    BackColor = Color.White;
                if (value == StoneColor.None)
                    BackColor = Color.Green;
                if (value == StoneColor.Gray)
                    BackColor = Color.Gray;
            }
        }
    }

    /// <summary>
    /// マスの色
    /// </summary>
    public enum StoneColor
    {
        None = 0,//未配置
        Black = 1,//黒
        White = 2,//白
        Gray = 3,//ヒント
    }
}
