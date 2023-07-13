namespace Week2Day4;

class Program
{
	static void Main()
	{
		var kucing1 = new Kucing("Gunawan",3,3,3000);
		var kucing2 = new Kucing("Botez",4,4,4000);
		var kucing3 = new Kucing("Alexandra",5,5,5000);
		
		var kucing4 = new Kucing();
		kucing4 = kucing1+kucing2+kucing3;
	}
}

class Kucing
{
	public string nama;
	public int goal;
	public int assist;
	public int price;
	
	public Kucing(string nama, int goal, int assist, int price)
	{
		this.nama = nama;
		this.goal = goal;
		this.assist = assist;
		this.price = price;
	}
	
	public static Kucing operator + (Kucing oren, Kucing cireng)
	{
		var putih = new Kucing();
		putih.nama = oren.nama + cireng.nama;
		putih.goal = oren.Goal + cireng.Goal;
		putih.assist = oren.assist + cireng.assist;
		putih.price = oren.price + cireng.price;
		
		return putih;
	}
	
	public static Kucing operator - (Kucing oren, Kucing cireng)
	{
		var putih = new Kucing();
		putih.nama = "Reuni";
		putih.goal = oren.goal - cireng.goal;
		putih.assist = oren.assist - cireng.assist;
		putih.price = oren.price - cireng.price;
		
		return putih;
	}
}