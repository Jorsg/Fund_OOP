using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Abstraction
{
	abstract class BaseClass
	{
		protected int _x = 100;
		protected int _y = 150;

		// Abstract method
		public abstract void AbstractMethod();
		//abstract property
		public abstract int X { get; set; }
		public abstract int Y { get; set; }
	}
}
