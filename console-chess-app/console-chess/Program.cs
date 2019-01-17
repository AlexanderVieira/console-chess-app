using Domain.Board.Entities;
using System;

namespace console_chess {
	class Program {
		static void Main(string[] args) {

			var pos = new Position(2, 4);
			Console.WriteLine("Position: " + pos);
			var board = new Board(8, 8);
			
		}
	}
}