using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Abstraction
{
    class DerivedClass: BaseClass
    {
		public override void AbstractMethod()
		{
			_x++;
			_y++;
		}
		public override int X // overriding property
		{
			get => _x + 10;
			set => _x = value;
			
		}
		public override int Y // overriding property
		{
			get => _y + 10;
			set => _y = value;
		}
	}
}
