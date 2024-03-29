﻿using System.Linq;
using System.Windows.Forms;


namespace osero.Common
{
    partial class Form1 : Form
    {
        /// <summary>
        /// 待ったの関数
        /// </summary>
        public static void Wait()
        {
            //戻せないときはそのまま
            if (osero.Form1.num == 0) return;
            
            int number = --osero.Form1.num;
            
            BoardStatus boardStatuses = new BoardStatus();
            boardStatuses.PutStone = osero.Form1.BoardStatus[number].PutStone;
            boardStatuses.ReturnStones = osero.Form1.BoardStatus[number].ReturnStones;
            if (boardStatuses.PutStone.StoneColor == StoneColor.Black ||
                boardStatuses.PutStone.StoneColor == StoneColor.White)
            {
                if (boardStatuses.PutStone.StoneColor == StoneColor.Black)
                {
                    //isYour = true;
                    foreach (Stone stone in boardStatuses.ReturnStones)
                        stone.StoneColor = StoneColor.White;
                    osero.Form1.boardInf.Items.Add("待ったを行いました。");
                }
                if (boardStatuses.PutStone.StoneColor == StoneColor.White)
                {
                    foreach (Stone stone in boardStatuses.ReturnStones)
                        stone.StoneColor = StoneColor.Black;
                }

                isYour = true;
                boardStatuses.PutStone.StoneColor = StoneColor.None;
                StoneNumber();
                var grayStones = osero.Form1.StonePosition.Cast<Stone>();
                grayStones = grayStones.Where(xx => xx.StoneColor == StoneColor.Gray);
                var hintPositions = grayStones.ToList();
                foreach (Stone stone in hintPositions)
                    stone.StoneColor = StoneColor.None;
                
            }

            return;
        }
    }
}
