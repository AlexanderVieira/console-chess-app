using Domain.Board.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Board.Entities {
	public class Piece {

		public Position Position { get; set; }
		public Color Color { get; protected set; }
		public int QtyMove { get; protected set; }
		public Board Board { get; protected set; }

		public Piece(Position position, Color color, Board board) {
			Position = position;
			Color = color;
			Board = board;
			QtyMove = 0;
		}
	}
}
