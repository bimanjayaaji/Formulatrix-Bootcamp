namespace ProgramEFCore;

partial class Program
{
	static void SectionTitle(string title)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("*");
		Console.WriteLine($"* {title}");
		Console.WriteLine("*");
		Console.ForegroundColor = previousColor;
	}

	static void Fail(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"Fail > {message}");
		Console.ForegroundColor = previousColor;
	}

	static void Info(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine($"Info > {message}");
		Console.ForegroundColor = previousColor;
	}
	
	static void Printer(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"{message}");
		Console.ForegroundColor = previousColor;
	}
	static string? GetInput()
	{
		return Console.ReadLine();
	}
}
