using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        public static BoardStatus BoardInf(Stone stone, List<Stone> stones) {
            BoardStatus boardStatuses = new BoardStatus();
            boardStatuses.PutStone = stone;
            boardStatuses.ReturnStones = stones;
            string Color = "";
            string BoardInf = "";
            if(stone.StoneColor == StoneColor.Black)
            {
                Color = "黒";
            }
            if (stone.StoneColor == StoneColor.White)
            {
                Color = "白";
            }
            BoardInf = String.Format("{0}手目({1},{2}){3}\n ",osero.Form1.num, stone.Colum, stone.Row, Color);
            osero.Form1.boardInf.Items.Add(BoardInf);
            return boardStatuses;
        }

    }
}
