using Static;

class Program 
{
	static void Main() 
	{
		Calculator calculator = new Calculator(2);
		Calculator calculator1= new Calculator(1);

		Console.WriteLine(Calculator.ReturnSizeCalc());
		Console.WriteLine(calculator.ReturnSize());
		Console.WriteLine(calculator1.ReturnSize());
	}
}