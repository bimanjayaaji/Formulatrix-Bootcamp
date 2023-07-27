using System.IO;

class Program
{
	static void Main()
	{
		using (var theWriter = new TheStringWriter())
		{
			theWriter.WriteSmth("Hola, ");
			theWriter.WriteSmth("LEk!");
			theWriter.ReadSmth();
		}
	}
}

public class TheStringWriter : IDisposable
{
	private StringWriter stringWriter;
	private bool disposed = false;
	
	public TheStringWriter()
	{
		stringWriter = new StringWriter();
		Console.WriteLine("Constructed TheStringWriter");
	}
	
	public void WriteSmth(string data)
	{
		stringWriter.Write(data);
		Console.WriteLine("TheStringWriter is writing : " + data);
	}
	
	public void ReadSmth()
	{
		Console.WriteLine("TheStringWriter is reading : " + stringWriter.ToString());
	}
	
	protected virtual void Dispose(bool disposing)
	{
		if(!disposed)
		{
			stringWriter.Dispose();
		}
		
		disposed = true;
		
		Console.WriteLine("Disposing");
	}
	
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	~TheStringWriter()
	{
		Dispose(false);
	}
}