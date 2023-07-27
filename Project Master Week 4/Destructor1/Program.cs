class Program
{
	static void Main()
	{
		// // deconstructers are not being run
		// Player player1 = new Player("player1");
		// Player player2 = new Player("player2");
		// Player player3 = new Player("player3"); 
		
		method1();
		method2();
		
		static void method1()
		{
			Human human1 = new Human("Human 1");
			Human human2 = new Human("Human 2"); 
			Human human3 = new Human("human 3");
		}
		
		static void method2()
		{
			Animal animal1 = new Animal("Animal 1");
			Animal animal2 = new Animal("Animal 2");
			Animal animal3 = new Animal("Animal 3");
		}
		
		GC.Collect();
		GC.WaitForPendingFinalizers();
		
		Console.ReadLine();
	}
}

public class Animal
{
	public string myString;
	public Animal(string something)
	{
		this.myString = something;
		Console.WriteLine("Constructed " + this.myString);
	}
	~Animal()
	{
		Console.WriteLine("Deconstructed " + this.myString);
		Human humanAnimal = new Human("Human Animal");
	}
}

public class Human
{
	public string myString;
	public Human(string something)
	{
		this.myString = something;
		Console.WriteLine("Constructed " + this.myString);
	}
	~Human()
	{
		Console.WriteLine("Deconstructed " + this.myString);
		Animal animalHuman = new Animal("Animal Human");
	}
}