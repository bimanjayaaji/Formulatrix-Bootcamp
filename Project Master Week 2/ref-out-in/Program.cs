namespace Week2Day1;

class Program
{
	static void Main()
	{
		int number = 15;
		int result;

		// ref
		MultiplyByTwoRef(ref number);
		Console.WriteLine("Using 'ref': " + number);

		// out
		MultiplyByTwoOut(out result);
		Console.WriteLine("Using 'out': " + result);

		// in
		int readonlyNumber = 5;
		MultiplyByTwoIn(in readonlyNumber);
	}
	
	static void MultiplyByTwoRef(ref int num)
    {
        num *= 2;
    }

    static void MultiplyByTwoOut(out int num)
    {
        num = 7;
        num *= 2;
    }

    static void MultiplyByTwoIn(in int num)
    {
        // num *= 2;  // error
        int result = num * 2;
        Console.WriteLine("Using 'in': " + result);
    }
}