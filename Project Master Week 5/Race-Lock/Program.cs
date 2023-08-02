class Program
{
	static async Task Main()
	{
		var brother = Task.Run(() => WC.Poop());
		var sister = Task.Run(() => WC.Poop());
		
		await Task.WhenAll(brother, sister);

		Console.WriteLine($"Counter: {WC.GetCounter()}");
		Console.ReadKey();
	}
}

public static class WC
{
	private static int _counter = 0;
	private static object _counterLock = new object();
	
	public static async Task Poop()
	{
		for (int i = 0; i < 100; i++)
		{
			lock (_counterLock)
			{
				_counter++;
				Console.WriteLine($"Counter from: {_counter}");
			}
			await Task.Delay(100);
		}
	}
	
	public static int GetCounter()
	{
		return _counter;
	}
}