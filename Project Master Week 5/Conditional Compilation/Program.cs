#define RELEASE

class Program
{
	static async Task Main(string[] args)
	{
		#if DEBUG
		Console.WriteLine("WINDOWS running");
		
		#elif RELEASE
		Console.WriteLine("ANDROID running");
		
		#endif
		string y = Console.ReadLine();
		Console.WriteLine(y);
		
		while (true)
		{
			Console.WriteLine("Botol makan sapi");
			Console.WriteLine("Pensilku");
			await Task.Delay(2000);
		}
	}
}