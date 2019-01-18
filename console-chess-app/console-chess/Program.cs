using Domain.Board.Entities;
using Domain.Board.Entities.Enums;
using Domain.Chess;
using System;

namespace console_chess {
	class Program {
		static void Main(string[] args) {

			var board = new MyBoard(8, 8);
			board.PutPiece(new Tower(Color.Preta, board), new Position(0, 0));
			board.PutPiece(new Tower(Color.Preta, board), new Position(1, 4));
			board.PutPiece(new King(Color.Preta, board), new Position(2, 5));

			Screen.PrintBoard(board);
		}
	}
}