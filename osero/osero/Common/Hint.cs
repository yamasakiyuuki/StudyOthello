using System.Linq;

namespace osero.Common
{
    partial class Form1
    {
        /// <summary>
        /// ヒントマスの判定
        /// </summary>
        public static void Hint()
        {
            var stones = osero.Form1.StonePosition.Cast<Stone>();
            stones = stones.Where(xx => xx.StoneColor == StoneColor.None 
            &&　GetRevarseStones(xx.Colum, xx.Row, StoneColor.Black).Any());
           
            var hintPositions = stones.ToList();
            foreach (Stone stone in hintPositions)
                stone.StoneColor = StoneColor.Gray;
        }
    }
}
