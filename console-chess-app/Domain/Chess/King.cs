using Domain.Board.Entities;
using Domain.Board.Entities.Enums;

namespace Domain.Chess {
	public class King : Piece{
		public King(Color color, MyBoard board):base(color, board) {

		}

		public override string ToString() {
			return "K";
		}
	}
}
