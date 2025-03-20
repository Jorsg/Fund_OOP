using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.CSharp_Reference.Override
{
	class TestOverride
	{
		public class Employee
		{
			public string Name { get; set; }

			protected double _basepay;

			//constructor to set the name and basepay values
			public Employee(string name, double basepay)
			{
				Name = name;
				_basepay = basepay;
			}

			//Declare virutal so it can be overriden
			public virtual double CalculatePay()
			{
				return _basepay;
			}
		}

		public class SalesEmployee : Employee
		{
			private double _salesbonus;
			//constructor to set the name, basepay and salesbonus values
			public SalesEmployee(string name, double basepay, double salesbonus) : base(name, basepay)
			{
				_salesbonus = salesbonus;
			}
			//Override the CalculatePay method
			// to take bonus into account
			public override double CalculatePay()
			{
				return base.CalculatePay() + _salesbonus;
			}
		}
	}
}
