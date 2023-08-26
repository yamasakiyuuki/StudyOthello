using osero.Common;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            CreatePictureBoxes();
        }

        /// <summary>
        /// スタートボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            GameStart();
            osero.Common.Form1.StoneNumber();
            boardInf.Items.Clear();
            num = 0;
        }
        /// <summary>
        /// 盤面作成の関数
        /// </summary>
        void CreatePictureBoxes()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int colum = 0; colum < 8; colum++)
                {
                    //盤面のマスを未配置の状態で初期化
                    Stone stone = new Stone(colum, row);
                    stone.Parent = this;
                    stone.Size = new Size(70, 70);
                    stone.BorderStyle = BorderStyle.FixedSingle;
                    stone.Location = new Point(leftTopPoint.X + colum * 70, leftTopPoint.Y + row * 70);
                    stone.StoneClick += osero.Common.Form1.Box_PictureBoxExClick;
                    stone.BackColor = Color.Green;
                    StonePosition[colum, row] = stone;
                }
            }
        }

        /// <summary>
        /// ゲームスタート処理の関数
        /// </summary>
        void GameStart()
        {
            //待ったボタンの無効化
            button4.Enabled = false;
            var stones = StonePosition.Cast<Stone>();

            //盤面のマスを初期化
            foreach (Stone stone in stones)
                stone.StoneColor = StoneColor.None;

            //オセロの初期盤面の配置
            StonePosition[3, 3].StoneColor = StoneColor.Black;
            StonePosition[4, 4].StoneColor = StoneColor.Black;
            StonePosition[3, 4].StoneColor = StoneColor.White;
            StonePosition[4, 3].StoneColor = StoneColor.White;

            //TODO 先手後手を変更できるようにする
            osero.Common.Form1.isYour = true;
        }
        
        /// <summary>
        /// 降参ボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            osero.Common.Form1.Surrender();
            
            //待ったボタンの無効化
            button4.Enabled = false;
        }

        /// <summary>
        /// ヒントボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //ヒントマスの初期化
            var grayStones = osero.Form1.StonePosition.Cast<Stone>();
            grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
            var hintPositions = grayStones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.None;

            //ヒントマスの表示
            osero.Common.Form1.Hint();
        }

        /// <summary>
        /// 待ったボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //初期盤面なら待ったをしない
            if (osero.Form1.num == 0)
            {
                button4.Enabled = false;
                return;
            }
            //前の自分のターンの盤面に更新
            osero.Common.Form1.Wait();
            osero.Common.Form1.Wait();

            //待った実行時の確認のメッセージボックスの表示(待った時に処理を実行させないため)
            DialogResult result = MessageBox.Show(
                    "待ったがされました", "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );

        }
    }
}
