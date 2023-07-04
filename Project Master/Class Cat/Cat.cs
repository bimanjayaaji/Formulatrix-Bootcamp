namespace CatMaker;

public class Cat
{
	public string name;
	public string colour;
	public int weight;
	public Cat(string name) 
	{
		this.name = name;
	}
	public void Eat(string food) 
	{
		Console.WriteLine($" {name} Eat {food}");
	}
	public void Eat(string food, string drink) 
	{
		Console.WriteLine($" {name} Eat {food} and {drink}");
	}
	
	public void Run() 
	{
		Console.WriteLine("/n Run /n" + name);
	}
	
	public void Fight() 
	{
		Console.WriteLine("Fight");
	}
}
