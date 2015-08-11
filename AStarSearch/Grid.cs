using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AStarSearch
{
    public class Grid
    {
        public int Size { get; set; }
        public Cell Start { get; set; }
        public Cell Finish { get; set; }
        public Point Origin { get; set; }

        private Cell[,] cells;

        public void InitializeGrid()
        {
            Origin = new Point(0, 0);
            cells = new Cell[Size, Size];
        }

        public void DrawGrid(Graphics Graf, Pen pencil)
        {
            Point startP = new Point();
            Point endP = new Point();

            startP.X = Origin.X;

        }
    }
}
