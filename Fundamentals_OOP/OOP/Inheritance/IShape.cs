using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Interfaces
{
	internal interface IShape
	{
		int triangleSides(int a, int b, int c);
		int squareSides(int a, int b, int c, int d);
		int rectangleSides(int a, int b, int c, int d);
		int circleSides(int a);
	}
}
