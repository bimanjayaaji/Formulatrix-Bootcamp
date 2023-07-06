using Character_Interface;

class Program
{
	static void Main()
	{
		Person CJ = new Person("Carl");
		string eventHolder = "";
		
		while (eventHolder != "0")
		{
			Console.Write("Enter Command for Human : ");
			eventHolder = Console.ReadLine();
			CJ.Commandment(eventHolder);
		}

	}
}