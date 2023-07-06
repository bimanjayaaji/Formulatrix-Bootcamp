namespace ParentLib;

public class Character
{
	static public string charName;
	public bool isWhite;
	
	public Character(string name, bool isWhite)
	{
		charName = name;
		this.isWhite = isWhite;
	}
	
	public Character()
	{
		charName = "BotChar";
		isWhite = false;
	}
	
	public static void Run()
	{
		Console.WriteLine(charName + " is running");
		
	}
	
	public static void Walk()
	{
		Console.WriteLine(charName + " is walking");
	}
	
	public static void Fight()
	{
		Console.WriteLine(charName + " is geludding");
	}
	
	
}