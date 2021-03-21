using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using osero.Common;

namespace osero
{
    public partial class Form1 : Form
    {
        Point leftTopPoint = new Point(50, 50);
        Stone[,] StonePosition = new Stone[8, 8];

        public Form1()
        {
            InitializeComponent();
            //for (int i = 0; i < 64; i++) {
            //this.pictureBoxList[i] = this.pictureBox1
            //}
            CreatePictureBoxes();
            GameStart();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
          //  this.pictureBox1.BackColor="brac"   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatePictureBoxes();
            GameStart();
        }
        void CreatePictureBoxes()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int colum = 0; colum < 8; colum++)
                {
                    Stone stone = new Stone(colum, row);
                    stone.Parent = this;
                    stone.Size = new Size(70, 70);
                    stone.BorderStyle = BorderStyle.FixedSingle;
                    stone.Location = new Point(leftTopPoint.X + colum * 70, leftTopPoint.Y + row * 70);
                    StonePosition[colum, row] = stone;
                    //stone.StoneClick += Box_PictureBoxExClick;
                    stone.BackColor = Color.Green;
                }
            }
        }

        void GameStart()
        {
            var stones = StonePosition.Cast<Stone>();
            foreach (Stone stone in stones)
                stone.StoneColor = StoneColor.None;

            StonePosition[3, 3].StoneColor = StoneColor.Black;
            StonePosition[4, 4].StoneColor = StoneColor.Black;

            StonePosition[3, 4].StoneColor = StoneColor.White;
            StonePosition[4, 3].StoneColor = StoneColor.White;

            //isYour = true;
            //toolStripStatusLabel1.Text = "あなたの手番です。";
        }

        /*private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStart();
        }*/
    }
}
