using Fundamentals_OOP.OOP.Abstraction;
using static Fundamentals_OOP.CSharp_Reference.Override.TestOverride;

internal class Program
{
	private static void Main(string[] args)
	{
		// To create an instance of a circle
		Circle circle = new Circle(5);
		var employee1 = new SalesEmployee("John", 1000, 500);
		var employee2 = new Employee("Jane", 1000);
		Console.WriteLine($"Employee1: {employee1.Name} earned: {employee1.CalculatePay()}");
		Console.WriteLine($"Employee2: {employee2.Name} earned: {employee2.CalculatePay()}");

		//Calculating and displaying the are of a circle
		//Console.WriteLine("The area of the circle: " + circle.GetArea());
		//circle.Method1();
		//circle.Method2();
		//var o = new DerivedClass();
		//o.AbstractMethod();
		//Console.WriteLine($"x = {o.X}, y = {o.Y}");
	}
}