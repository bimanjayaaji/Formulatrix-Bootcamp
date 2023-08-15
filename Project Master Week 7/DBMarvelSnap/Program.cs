using MarvelSnapDB;
using Action;

namespace MainProgram;

class Program
{
	private static string _path = String.Empty;
	
	static void Main(string[] args)
	{
		MainProgram();
	}
	
	static void MainProgram()
	{
		string? input;
		bool isValidInput = false;
		Console.Clear();
		while(!isValidInput)
		{
			Console.WriteLine("1) Querying Players");
			Console.WriteLine("2) Add Player");
			Console.WriteLine("3) Add Card");
			Console.WriteLine("X) Exit");
			Console.Write("Enter a command: ");
			input = Console.ReadLine();
			
			switch (input?.ToLower())
			{
				case "1":
					Querying.QueryingPlayers();
					break;
				case "2":
					Console.Write("Enter player's name: ");
					string? playerName = Console.ReadLine(); 
					if (CUD.AddPlayer(playerName))
					{
						Console.WriteLine("Successfully added player");	
					}
					break;
				case "3":
					Console.Write("Enter Card's name: ");
					string? cardName = Console.ReadLine();
					Console.Write("Enter Card's ID: ");
					int cardID;
					bool _ = int.TryParse(Console.ReadLine(), out cardID);
					Console.Write("Enter Player's ID: ");
					int playerID;
					bool __ = int.TryParse(Console.ReadLine(), out playerID);
					if (CUD.AddCard(cardName, cardID, playerID))
					{
						Console.WriteLine("Successfully added Card");
					}
					break;
				case "x":
					isValidInput = true;
					break;
				default:
					Console.WriteLine("Invalid input. Please try again.");
					break;
			}
		}
		
	}
}

