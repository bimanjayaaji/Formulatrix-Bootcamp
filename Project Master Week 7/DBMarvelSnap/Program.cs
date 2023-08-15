using MarvelSnapDB;

class Program
{
	private static string _path = String.Empty;
	
	static void Main(string[] args)
	{
		_path = Path.Combine(Environment.CurrentDirectory, "MarvelSnap.db");
		string connectionPath = $"Data Source={_path}";
		MarvelSnap db = new MarvelSnap(_path);
		
		Main();
	}
	
	static void Main()
	{
		
	}
}

