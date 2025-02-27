using Fundamentals_OOP.OOP.Abstraction;

internal class Program
{
	private static void Main(string[] args)
	{
		// To create an instance of a circle
		Circle circle = new Circle(5);
		
		//Calculating and displaying the are of a circle
		Console.WriteLine("The area of the circle: " + circle.GetArea());
		circle.Method1();
		circle.Method2();
		var o = new DerivedClass();
		o.AbstractMethod();
		Console.WriteLine($"x = {o.X}, y = {o.Y}");
	}
}