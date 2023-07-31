using System.Diagnostics;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(Substract(2,3));
		
		Debug.WriteLine("debug writeline");
		Trace.WriteLine("trace writeline");
		Debug.Assert(true,"debug assert true");
		Trace.Assert(false,"trace assert false");
	}
	
	static int Substract(int x, int y)
	{
		return (x-y);
	}
}