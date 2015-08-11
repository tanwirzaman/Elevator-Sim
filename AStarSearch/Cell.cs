using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AStarSearch
{
    public class Cell
    {
        private byte rowIndex;
        private byte columnIndex;

        public Point CoOrds{get;set;}
        public bool Obstacle { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }

        public byte RowIndex
        {
            get { return rowIndex; }
        }

        public byte ColumnIndex
        {
            get { return columnIndex; }
        }
    }
}
