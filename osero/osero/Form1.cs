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
        public static BoardStatus[] BoardStatus = new BoardStatus[60];
        public static System.Windows.Forms.Label komaNumber;
        //public static System.Windows.Forms.Label board;
        public static System.Windows.Forms.ListBox boardInf;
        public static int num = 0;
        public Form1()
        {
            InitializeComponent();
            komaNumber = this.label1;
            //board = this.label2;
            boardInf = this.listBox1;
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
            // string reset = "打ち手(行,列) 色(左上から0,0)\n";
            // board.Text = reset;
            boardInf.Items.Clear();
            num = 0;
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

        public void GameStart()
        {
            button4.Enabled = false;
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
        /// <summary>
        /// スタートボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStart();
        }
        /// <summary>
        /// 降参ボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            osero.Common.Form1.Surrender();
            button4.Enabled = false;
        }
        /// <summary>
        /// ヒントボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var grayStones = osero.Form1.StonePosition.Cast<Stone>();
            grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
            var hintPositions = grayStones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.None;
            osero.Common.Form1.Hint();
        }

        /// <summary>
        /// 待ったボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button4_Click(object sender, EventArgs e)
        {
            if (osero.Form1.num == 0) return;

            if (!osero.Common.Form1.isYour)
            {
                await Task.Delay(1000);
            }
            osero.Common.Form1.Wait();
            osero.Common.Form1.Wait();

            DialogResult result = MessageBox.Show(
                    "待ったがされました", "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );

        }
    }
}
