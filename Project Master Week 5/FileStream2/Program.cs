using System.Diagnostics;

class Program
{
	static async Task Main()
	{
		Task brother = Task.Run(() => StreamFile.Write());
		Task sister = Task.Run(() => StreamFile.Write2());
		Task sw = Task.Run(() => StreamFile.SW());
		
		Task task = Task.WhenAll(brother, sister);
		await task;
		Console.WriteLine("Done");
		await Task.WhenAny(task, sw);

	}
}

public static class StreamFile
{
	private static string path = @".\file.txt";
	
	
	public static async Task Write()
	{ 
		using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))) // fs declared in the scope of sw
		{
			for (int i = 0; i < 10000000; i++)
			{
				writer.WriteLine("Written from StreamWriter");
				writer.WriteLine("Another line from StreamWriter");	
			}
		}
	}
	
	public static async Task Write2()
	{
		using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))) // fs declared in the scope of sw
		{
			for (int i = 0; i < 10000000; i++)
			{
				writer.WriteLine("Written from StreamWriter");
				writer.WriteLine("Another line from StreamWriter");	
			}
		}
	}
	
	public static async Task SW()
	{
		Stopwatch sw = Stopwatch.StartNew();
		sw.Reset();
		sw.Start();
		while (true)
		{
			Console.Clear();
			Console.WriteLine(sw.ElapsedMilliseconds);
			await Task.Delay(1000);
		}
	}
}