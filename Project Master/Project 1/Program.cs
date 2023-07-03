// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

class Program 
{
	static int myint = 2;
	static string mystring = "i am a mystring var";
	
	static void Main()
	{
		Console.WriteLine("Hello, World!");
		Console.WriteLine(myint);
		Message();
	}
	
	static void Message()
	{
		Console.WriteLine("Hello, Bang!");		
		Console.WriteLine(mystring);
	}
}
