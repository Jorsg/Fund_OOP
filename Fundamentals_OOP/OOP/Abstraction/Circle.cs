﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Abstraction
{
	class Circle : Shape, I
	{
		private double radio;

		// Constructor
		public Circle(double radio)
		{
			this.radio = radio;
		}

		// Implementating the abstract method for calculating the área of a circle
		public override double GetArea()
		{
			return Math.PI * radio * radio;
		}

		public void Method1()
		{
			Console.WriteLine("Method1");
		}

		public void Method2()
		{
			Console.WriteLine("Method2");
		}
	}
}
