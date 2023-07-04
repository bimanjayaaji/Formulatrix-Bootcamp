using DogMaker;

namespace Program;

class Program
{
	static void Main()
	{
		Dog miki = new Dog("miki");
		miki.Eat("penyetan");
		miki.Run();
		Dog moli = new Dog("moli");
		moli.Eat("kfc","sego");
		moli.Fight();
	}
}