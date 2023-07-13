namespace Week2Day4;

class Program
{
	static void Main()
	{
		var lele1 = new Lele("Antonio");
		var lele2 = new Lele("Gomez");
		var lele3 = new Lele("Alexander");	
		var lele4 = new Lele("Gunawan");
		
		lele4.lelele.Add(lele1);
		lele4.lelele.Add(lele2);
		lele4.lelele.Add(lele3);
		
		lele4.PanggilNama();
	}
}

class Lele
{
	public string namaLele;
	public List<Lele> lelele = new List<Lele>();
	
	public Lele(string nama)
	{
		this.namaLele = nama;
	}
	
	public void PanggilNama()
	{
		foreach (var lele in this.lelele)
		{
			Console.WriteLine("kulo asmanipun " + lele.namaLele);
		}
	}
}