// tictactoe

class Program
{
	static void Main()
	{
		var tictactoe = new TicTacToe();
		
		tictactoe.PlayerInit();
		// tictactoe.DisplayBoard();
		tictactoe.GameLoop();
	}
}

class TicTacToe
{	
	Player player1 = new();
	Player player2 = new();
	char[,] boardCond = new char[3,3];
	
	public TicTacToe()
	{
		for(int i = 0; i <= 2; i++)
		{
			for (int j = 0; j <= 2; j++)
			{
				boardCond[i,j] = '_';
			}
		}
	}
	
	public void DisplayBoard()
	{
		for(int i = 0; i <= 2; i++)
		{
			Console.WriteLine("");
			Console.Write("|");
			for (int j = 0; j <= 2; j++)
			{
				Console.Write($" {boardCond[i,j]} |");
			}
		}
		Console.WriteLine("");
		Console.WriteLine("");
	}
	
	public void PlayerInit()
	{
		Console.Write("Enter Player 1 Name : ");
		player1.Name = Console.ReadLine();
		Console.Write("Enter Player 2 Name : ");
		player2.Name = Console.ReadLine();
		
		Console.WriteLine("Generating random mark to each player...");
		LoadingIcon.Display();
		
		Random random = new Random();
		int randomNumber = random.Next(0,2);
		if (randomNumber == 0)
		{
			player1.Mark = 'x';
			player2.Mark = 'o';
		} 
		else
		{
			player1.Mark = 'o';
			player2.Mark = 'x';	
		}
		
		Console.WriteLine($"{player1.Name} using {player1.Mark} | {player2.Name} using {player2.Mark}");
		
		Console.WriteLine("");
		Console.Write("Press any key to continue...");
		Console.ReadKey();
	}
	
	public void GameLoop()
	{
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("Let's start the game!");
		int row, column;
		
		while (true)
		{
			DisplayBoard();
			Console.WriteLine($"{player1.Name}'s turn");
			Console.Write("Choose Row (0-2) : ");
			string rowed = Console.ReadLine();
			row = int.Parse(rowed);
			Console.Write("Choose Column (0-2) : ");
			string columned = Console.ReadLine();
			column = int.Parse(columned);
			
			// check udah keisi belom
			if (boardCond[row,column] == '_')
			{
				boardCond[row,column] = player1.Mark;	
			} 
			else
			{
				// cw dan ngulang	
			}
			// check win
			
			DisplayBoard();
			Console.WriteLine($"{player2.Name}'s turn");
			Console.Write("Choose Row (0-2) : ");
			rowed = Console.ReadLine();
			row = int.Parse(rowed);
			Console.Write("Choose Column (0-2) : ");
			columned = Console.ReadLine();
			column = int.Parse(columned);
			
			// check udah keisi belom
			if (boardCond[row,column] == '_')
			{
				boardCond[row,column] = player1.Mark;	
			} 
			else
			{
				// cw dan ngulang	
			}
			// check win
		}
	}
}

class Player
{
	private char mark;
	public char Mark
	{
		get { return mark; }
		set { mark = value; }
	}
	
	private string? name;
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
}

public class LoadingIcon
{
	private static char[] _frames = { '|', '/', '-', '\\' };
	
	public static void Display()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.Write(_frames[i % _frames.Length]);
			Thread.Sleep(200);
			Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
		}
	}
}