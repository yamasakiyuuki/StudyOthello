using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
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
    public enum StoneColor
    {
        None = 0,
        Black = 1,
        White = 2,
        Gray = 3,
    }
}
