class Program
{
	static async Task Main()
	{
		Task[] tasks = new Task[7];

			for (int i = 1; i <= tasks.Length; i++)
			{
				int taskId = i;
				tasks[i - 1] = Task.Run(() => WC.Poop(taskId));
			}
			await Task.WhenAll(tasks);
			Console.ReadKey();
	}
}

public static class WC
{
	private static Semaphore semaphore = new Semaphore(2, 2);
	public static async Task Poop(int taskId)
	{
		Console.WriteLine($"Student {taskId} wants to use WC");
		try
		{   
			semaphore.WaitOne();
			Console.WriteLine("Success: Student " + taskId + " has pooped");
			Thread.Sleep(2500);
			Console.WriteLine($"Task {taskId} Exit.");
		}
		finally
		{
			semaphore.Release();
		}
	}
}