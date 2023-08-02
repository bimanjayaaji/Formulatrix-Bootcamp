class Program
{
	static async Task Main()
	{
		CancellationTokenSource source = new CancellationTokenSource();
		CancellationToken token = source.Token;
		
		Task task1 = Task.Run(() => FightMode.Punching(token)); // token --> status
		Task task2 = Task.Run(() => FightMode.Intervene(source)); // yang nge-invoke
		
		await task1;
		Console.WriteLine("Fighting finished");
	}
}

public class FightMode
{
	public static async Task Punching(CancellationToken token)
	{
		for (int i = 0; i <= 100; i++)
		{
			if (token.IsCancellationRequested)
			{
				Console.WriteLine("Intervened");
				return;
			}
			Console.WriteLine("Still fighting!");
			await Task.Delay(500);	
		}
	}
	
	public static async Task Intervene(CancellationTokenSource source)
	{
		if (Console.ReadKey().KeyChar == ' ')
		{
			source.Cancel();
		}
	}
}