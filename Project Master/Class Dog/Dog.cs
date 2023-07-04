namespace DogMaker;

public class Dog
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
		Console.WriteLine($"{name} Eat {food}");
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
