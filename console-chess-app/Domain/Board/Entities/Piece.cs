using Domain.Board.Entities.Enums;

namespace Domain.Board.Entities {
	public class Piece {

		public Position Position { get; set; }
		public Color Color { get; protected set; }
		public int QtyMove { get; protected set; }
		public MyBoard Board { get; protected set; }

		public Piece(Color color, MyBoard board) {
			Position = null;
			Color = color;
			Board = board;
			QtyMove = 0;
		}
	}
}
