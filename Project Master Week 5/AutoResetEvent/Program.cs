// STILL ERROR

class Prpgram
{
	static async Task Main()
	{
		await WC.Whistle();
		await WC.MainPoop();
	}
}

public static class WC
{
	private static Task pooper1 = null;
	private static Task pooper2 = null;
	private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
	
	public static async Task MainPoop()
	{
		Console.WriteLine("Poopers are waiting for signals");
		await Task.Run(() => autoResetEvent.WaitOne());
		Poop(1);
		Poop(2);
	}
	
	public static async Task Whistle()
	{
		if (Console.ReadKey().KeyChar == ' ')
		{
			autoResetEvent.Set();
			Console.WriteLine("Whistle signaled pooper to poop!");
		}	
	}
	
	public static Poop(int id)
	{
		Console.WriteLine($"Pooper {id} is pooping");
	}
}