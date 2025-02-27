using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.CSharp_Reference.Override
{
	//The overrider modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
	//In the following example, the Square class must provide an override implementation of GetArea because GetArea is inherited from an abstract Shape class.
	abstract class Shape
	{
		public abstract double GetArea();
	}

	class Square : Shape
	{
		private double _side;
		// Constructor
		public Square(int n) => _side = n;
		// Implementating the abstract method for calculating the área of a square
		public override double GetArea() => _side * _side;
	}
}
