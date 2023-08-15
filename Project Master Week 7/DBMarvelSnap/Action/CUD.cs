using System.Data.Common;
using MarvelSnapDB;

namespace Action;

public class CUD
{
	public static bool AddPlayer(string? name)
	{
		using (MarvelSnap db = new())
		{
			Player player = new Player
			{
				PlayerName = name
			};
			
			db.Players.Add(player);
			db.SaveChanges();
			return true;
		}
	}
	
	public static bool AddCard(string? name, int cardID, int playerID)
	{
		using (MarvelSnap db = new())
		{
			Card card = new Card
			{
				CardName = name,
				CardId = cardID,
				PlayerId = playerID
			};
			
			db.Cards.Add(card);
			db.SaveChanges();
			return true;
		}
		
		
		
	}
}