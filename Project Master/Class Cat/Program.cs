using CatMaker;
using Class_Cat_2;

namespace Program;
class Program 
{
	static void Main() 
	{
		Cat alex = new Cat("alex");
		alex.Eat("Beef");
		alex.Run();
		Cat ferguso = new Cat("ferguso");
		ferguso.Eat("Beef","water");
		ferguso.Fight();
	}
}
