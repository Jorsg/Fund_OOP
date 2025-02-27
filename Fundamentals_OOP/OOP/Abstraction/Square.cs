using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Abstraction
{
    class Square: Shape
    {
		private double _side;
		// Constructor
		public Square(int n) => _side = n;

		// Implementating the abstract method for calculating the área of a square
		public override double GetArea() => _side * _side;

	}
}
