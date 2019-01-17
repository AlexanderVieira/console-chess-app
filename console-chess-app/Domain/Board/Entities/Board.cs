using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Board.Entities {
	public class Board {
		public int NumLines { get; set; }
		public int NumColumns { get; set; }
		private Piece[,] pieces;

		public Board(int numLines, int numColumns) {
			NumLines = numLines;
			NumColumns = numColumns;
			pieces = new Piece[numLines, numColumns];
		}
	}
}
