using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Abstraction
{
	class Circle : Shape
	{
		private double radio;

		// Constructor
		public Circle(double radio)
		{
			this.radio = radio;
		}

		// Implementating the abstract method for calculating the área of a circle
		public override double CalculatingArea()
		{
			return Math.PI * radio * radio;
		}
	}
}
