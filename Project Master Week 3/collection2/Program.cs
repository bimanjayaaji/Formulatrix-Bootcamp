namespace week3day1;

class Program
{
	static void Main()
	{
		// initializing a deck of card
		SetCards deck = new SetCards();
		
		// shuffling cards
		deck.ShuffleCards();
		
		// take 5 cards out to a player
		List<SingleCard> player1 = deck.Draw5Out();
		
		int counter = 1;
		foreach (var card in player1)
		{
			Console.WriteLine($"{counter}. {card.jenis} | {card.rank}");
			counter++;
		}
		
		// printing card sequence
		// deck.CardsSequence();
	}
}

public enum Jenis
{
	Wajik = 0,
	Hati, Keriting, Waru
}

public enum Rank
{
	Ace = 0,
	Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
	Jack, Queen, King
}

class SingleCard
{
	public Jenis jenis {get;}
	public Rank rank {get;}
	
	public SingleCard(Jenis x, Rank y)
	{
		jenis = x;
		rank = y;
	}
}

class SetCards
{
	private List<SingleCard> setCardComplete = new List<SingleCard>();
	private Jenis jenis = new Jenis();
	private Rank rank = new Rank();
	
	public SetCards()
	{
		foreach (Jenis jenis in Enum.GetValues(typeof(Jenis)))
		{
			foreach (Rank rank in Enum.GetValues(typeof(Rank)))
			{
				SingleCard card = new SingleCard(jenis,rank);
				setCardComplete.Add(card);	
			}
		}
	}
	
	public void ShuffleCards()
	{
		Random random = new Random();
		int n = setCardComplete.Count;
		
		while (n > 1)
		{
			n--;
			int k = random.Next(n + 1);
			SingleCard value = setCardComplete[k];
			setCardComplete[k] = setCardComplete[n];
			setCardComplete[n] = value;
		}
	}
	
	public List<SingleCard> Draw5Out()
	{
		List<SingleCard> drawed5 = new List<SingleCard>();
		
		for (int drawed = 0  ; drawed <= 4 ; drawed++)
		{
			drawed5.Add(setCardComplete[setCardComplete.Count-1]);
			setCardComplete.RemoveAt(setCardComplete.Count-1);
		}
		
		return drawed5;
	}
	
	public void CardsSequence()
	{
		int counter = 1;
		foreach (var x in setCardComplete)
		{
			Console.WriteLine($"{counter}. {x.jenis} | {x.rank}");
			counter++;
		}
	}
}