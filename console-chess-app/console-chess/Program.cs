﻿using Domain.Board.Entities;
using System;

namespace console_chess {
	class Program {
		static void Main(string[] args) {

			var board = new Board(8, 8);
			Screen.PrintBoard(board);
			
		}
	}
}