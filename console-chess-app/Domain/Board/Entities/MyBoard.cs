namespace Domain.Board.Entities {
	public class MyBoard {
		public int NumLines { get; set; }
		public int NumColumns { get; set; }
		private Piece[,] pieces;

		public MyBoard(int numLines, int numColumns) {
			NumLines = numLines;
			NumColumns = numColumns;
			pieces = new Piece[numLines, numColumns];
		}

		public Piece Piece(int line, int column) {
			return pieces[line, column];
		}

		public Piece Piece(Position pos) {
			return pieces[pos.Line, pos.Column];
		}

		public void PutPiece(Piece piece, Position position) {
			pieces[position.Line, position.Column] = piece;
			piece.Position = position;
		}
	}
}
