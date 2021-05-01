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
        public static Stone[,] StonePosition = new Stone[8, 8];
        public static System.Windows.Forms.Label komaNumber;
        public Form1()
        {
            InitializeComponent();
            komaNumber = this.label1;
            //for (int i = 0; i < 64; i++) {
            //this.pictureBoxList[i] = this.pictureBox1
            //}
            CreatePictureBoxes();
            //GameStart();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
          //  this.pictureBox1.BackColor="brac"   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CreatePictureBoxes();
            GameStart();
            osero.Common.Form1.StoneNumber();
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
                    //StonePosition[colum, row] = stone;
                    stone.StoneClick += osero.Common.Form1.Box_PictureBoxExClick;
                    stone.BackColor = Color.Green;
                    StonePosition[colum, row] = stone;
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

            osero.Common.Form1.isYour = true;
            //toolStripStatusLabel1.Text = "あなたの手番です。";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            osero.Common.Form1.Surrender();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var grayStones = osero.Form1.StonePosition.Cast<Stone>();
            grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
            var hintPositions = grayStones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.None;
            osero.Common.Form1.Hint();
        }
    }
}
