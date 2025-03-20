using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.CSharp_Reference.Readonly
{
	//In this example, the value of the field _year can't be changed in the method ChangeYear, even though it was assigened a value in the constructor.
	class Age
	{
		private readonly int _year;

		public Age(int year)
		{
			_year = year;
		}

		void ChangeYear()
		{
			// Error CS0191  A readonly field cannot be assigned to (except in a constructor or a variable initializer)
			// _year = 1967;
		}

		// You can assign a value to a readonly field only in the following contexts:
		// When the variable is initialized in the declaration, for example, private readonly int y = 5;
		//In the static constructor of the class that contains the readonly field.
		// These constructor are also the only context in which it's valid to pass a readonly field as an out or ref parameter.
	}
}
