using Domain.Board.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess {
	public class Screen {

		public static void PrintBoard(Board board) {

			for (int i = 0; i < board.NumLines; i++) {
				for (int j = 0; j < board.NumColumns; j++) {
					if (board.Piece(i, j) == null) {
						Console.Write("- ");
					}
					else {
						Console.Write(board.Piece(i, j) + " ");
					}

				}
				Console.WriteLine();
			}
		}
	}
}
