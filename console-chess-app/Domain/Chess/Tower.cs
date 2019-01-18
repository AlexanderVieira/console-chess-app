using Domain.Board.Entities;
using Domain.Board.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chess {
	public class Tower : Piece{

		public Tower(Color color, MyBoard board) : base(color, board) {

		}

		public override string ToString() {
			return "T";
		}
	}
}
