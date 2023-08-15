using Microsoft.EntityFrameworkCore;
using MarvelSnapDB;

namespace Action;

public class Querying
{
	public static void QueryingPlayers()
	{
		using (MarvelSnap db = new())
		{
			IQueryable<Player> players = db.Players.Include(c => c.Cards);
			
			if ((players == null) || (!players.Any()))
			{
				Console.WriteLine("No players Found");
				return;
			}
			
			Console.WriteLine($"ToQueryString: {players.ToQueryString()}");
			foreach (var player in players)
			{
				Console.WriteLine($"{player.PlayerName} has {player.Cards.Count} cards.");
				foreach(var card in player.Cards)
				{
					Console.WriteLine($"|	{card.CardName}");
				}
				Console.WriteLine("-----");
			}
		}
	}
}