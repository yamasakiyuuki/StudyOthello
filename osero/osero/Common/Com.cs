using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        public static void EnemyThink()
        {
            bool isComPassed = false;
            bool isYouPassed = false;
            while (true)
            {
                // Cast メソッドで 1次元に
                var stones = osero.Form1.StonePosition.Cast<Stone>();

                // 石が置かれていない場所で挟むことができる場所を探す。
                stones = stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.White).Any());
                var hands = stones.ToList();
                int count = hands.Count();
                if (count > 0)
                {
                    // 石をおける場所が見つかったらそのなかから適当に次の手を選ぶ
                    Stone stone = hands[new Random().Next() % count];

                    // 石を置いてひっくり返す
                    osero.Form1.StonePosition[stone.Colum, stone.Row].StoneColor = StoneColor.White;
                    List<Stone> stones1 = GetRevarseStones(stone.Colum, stone.Row, StoneColor.White);
                    stones1.Select(xx => xx.StoneColor = StoneColor.White).ToList();
                }
                else
                {
                    if (isYouPassed)
                    {
                        // 双方に「手」が存在しない場合はゲームセットとする
                        OnGameset();
                        return;
                    }

                    // 石をおける場所が見つからない場合はパス
                    isComPassed = true;
                }

                // プレイヤーの手番だが、「手」は存在するのか？
                stones = osero.Form1.StonePosition.Cast<Stone>();
                stones = stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.Black).Any());
                hands = stones.ToList();
                count = hands.Count();

                // 「手」が存在するならプレーヤーの手番とする
                if (count > 0)
                {
                    isYour = true;
                    if (isComPassed) { 
                    //toolStripStatusLabel1.Text = "コンピュータはパスしました。あなたの手番です。";
                    }

                    else
                        //toolStripStatusLabel1.Text = "あなたの手番です。";
                        return;
                }
                else
                {
                    // 「手」が存在しない場合はもう一度コンピュータの手番とする
                    if (!isComPassed)
                    {
                        isYouPassed = true;
                        //toolStripStatusLabel1.Text = "あなたの手番ですが手がありません";
                    }
                    else
                    {
                        // 双方に「手」が存在しない場合はゲームセットとする
                        OnGameset();
                        return;
                    }
                }
            }
        }
    }
}
