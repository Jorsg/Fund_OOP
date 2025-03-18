using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_OOP.OOP.Inheritance
{
	public class FatherClass
	{
		public string Tall { get; set; }
		public string Blond { get; set; }
		public string BlueEyes { get; set; }
		public string Rich { get; set; }

		public virtual void Work()
		{
			Console.WriteLine("Father is working");
		}
	}

	public class SonClass : FatherClass
	{
		
		public SonClass()
		{
			this.Tall = "Tall";
			this.Blond = "Blond";
			this.BlueEyes = "Blue Eyes";
			this.Rich = "Rich";
		}
		
		public override void Work()
		{
			Console.WriteLine("Son is working");
			base.Work();
		}
		
		
		public void Play()
		{
			Console.WriteLine("Son is playing");
		}
	}
}
