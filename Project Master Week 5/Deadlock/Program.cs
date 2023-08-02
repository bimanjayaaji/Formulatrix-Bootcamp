class Program
{
	static async Task Main()
	{
		await Runner.MainRun();
	}
}

public class Runner
{
	private static Task runner1 = null;
	private static Task runner2 = null;
	
	public static async Task MainRun()
	{
		runner1 = Task.Run(() => Runner1());
		runner2 = Task.Run(() => Runner2());
		
		await Task.WhenAll(runner1, runner2);
		Console.WriteLine("Marathon completed!");
		Console.ReadKey();
	}
	
	public static async Task Runner1()
	{
		Console.WriteLine("Runner 1 started");
		await Task.Delay(100);

		Console.WriteLine("Runner 1 waiting for Runner 2");
		await runner2;

		Console.WriteLine("Runner 1 finished");
	}
	
	public static async Task Runner2()
	{
		Console.WriteLine("Runner 2 started");
		await Task.Delay(100);

		Console.WriteLine("Runner 2 waiting for Runner 1");
		await runner1;

		Console.WriteLine("Runner 2 finished");
	}
}

// -----

