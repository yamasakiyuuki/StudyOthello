using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osero.Common
{
    partial class Form1
    {
        public static void Hint()
        {
            var stones = osero.Form1.StonePosition.Cast<Stone>();
            stones = stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.Black).Any());
            //stones.Where(xx => xx.StoneColor == StoneColor.None && GetRevarseStones(xx.Colum, xx.Row, StoneColor.Black).Any())
            //    .Select(stone =>
            //       osero.Form1.StonePosition[stone.Colum, stone.Row].StoneColor = StoneColor.Gray
            //        //stone.StoneColor = StoneColor.Gray
            //    );

            var hintPositions = stones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.Gray;
            
            //hintPosition[0].StoneColor = StoneColor.Gray;
            //hintPosition.Select(s => s.StoneColor = StoneColor.Gray);


        }
    }
}
