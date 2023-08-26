using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace osero.Common
{
    partial class Form1 : Form
    {
        /// <summary>
        /// コンピュータの手番の実行
        /// </summary>
        public static void EnemyThink()
        {
            //パスの判別するための変数
            bool isComPassed = false;
            bool isYouPassed = false;

            while (true)
            {
                var stones = osero.Form1.StonePosition.Cast<Stone>();

                // 石が配置されていない場所で挟むことができる場所を探す
                stones = stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.White).Any());
                
                var hands = stones.ToList();
                int count = hands.Count();
                if (count > 0)
                {
                    // 石を配置できる場所が見つかったらそのなかからランダムに次の手を選ぶ
                    Stone stone = hands[new Random().Next() % count];

                    // 石を配置して反転処理を実行
                    osero.Form1.StonePosition[stone.Colum, stone.Row].StoneColor = StoneColor.White;
                    List<Stone> stones1 = GetRevarseStones(stone.Colum, stone.Row, StoneColor.White);
                    stones1.Select(xx => xx.StoneColor = StoneColor.White).ToList();
                    osero.Form1.BoardStatus[osero.Form1.num++] = osero.Common.Form1.BoardInf(stone, stones1);
                }
                else
                {
                    if (isYouPassed)
                    {
                        // 二人ともが配置できなかった場合ゲームセット
                        OnGameset();
                        return;
                    }

                    // 石を配置できる場所が見つからない場合パス
                    isComPassed = true;
                }

                // プレイヤーが配置できるのかを判定
                stones = osero.Form1.StonePosition.Cast<Stone>();
                stones = stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.Black).Any());
                hands = stones.ToList();
                count = hands.Count();

                // 配置できる場所が存在するならプレーヤーの手番とする
                if (count > 0)
                {
                    isYour = true;
                    return;
                }
                else
                {
                    // 配置できる場所が存在しない場合はもう一度コンピュータの手番とする
                    if (!isComPassed)
                    {
                        isYouPassed = true;
                    }
                    else
                    {
                        // 二人ともが配置できなかった場合ゲームセット
                        OnGameset();
                        return;
                    }
                }
            }
        }
    }
}
