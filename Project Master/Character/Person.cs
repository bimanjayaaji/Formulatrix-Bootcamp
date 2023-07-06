namespace Character_Interface;

public class Person : IBody, IPersonality
{
	public string name;
	
	public Person(string name) 
	{
		this.name = name;
	}
	
	// ------- command -------
	
	public void Commandment(string command)
	{
		switch(command)
		{
			case "1":
				FootMove(); break;
			case "2":
				HandMove(); break;
			case "3":
				HandNyekel(); break;
			case "4":
				HeadMove(); break;
			case "5":
				HeadMlengos(); break;
			// skipped
			case "11":
				ChangeName(); break;
			case "12":
				GetName(); break;
			case "13":
				Calculating(); break;
		}
	}
	
	// ------- bagian2 body -------
	
	public void FootMove() 
	{
		Console.WriteLine(name + " Foot Moving");
	}
	public void HandMove()
	{
		Console.WriteLine(name + " Hand Moving");
	}
	public void HandNyekel()
	{
		Console.WriteLine(name + " Hand Nyekeling");
	}
	public void HeadMove()
	{
		Console.WriteLine(name + " Head Moving");
	}
	public void HeadMlengos()
	{
		Console.WriteLine(name + " Head Mlengosing");
	}
	public void TorsoDitempel2i()
	{
		Console.WriteLine(name + " Torso Tertempel");
	}
	public void NgretekGeger()
	{
		Console.WriteLine(name + " Geger Terkretek");
	}
	
	// ------- body -------
	
	public void BodyWalking()
	{
		Console.WriteLine(name + " Berjalan jalannn berjalannn jalannnn:)");
	}
	public void BodyRunning()
	{
		Console.WriteLine(name + " Lari lari lariiiii");
	}
	public void BodyKayang()
	{
		Console.WriteLine(name + " Hmmmhkkk hhhhhhh... kayang");
	}
	
	// ------- bagian2 personality -------
	
	public void Angry()
	{
		Console.WriteLine(name + " says djiannc****... Angry");
	}
	public void Sad()
	{
		Console.WriteLine(name + " says Halah Mboh wis pasrah... Sad");
	}
	public void Happy()
	{
		Console.WriteLine(name + " says Alhamdulilahhh... Happy");
	}
	public void Think()
	{
		Console.WriteLine(name + " humming Hmmmmmmm... Thinking");
	}
	public void Reflect()
	{
		Console.WriteLine(name + " is silent.......... Reflecting");
	}
	public void Planning()
	{
		Console.WriteLine(name + " is mumet Pie nek ngene ngene ngene? Planning");
	}
	public void Calculating()
	{
		double result = 0;
		
		Console.WriteLine("Welcome to " + name + " simple calculator");
		Console.Write("Enter 1st num : ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter operator : ");
		string op = Console.ReadLine();
		Console.Write("Enter 2nd num : ");
		double num2 = Convert.ToDouble(Console.ReadLine());
		
		switch (op)
		{
			case "+": result = num1 + num2; break;
			case "-": result = num1 - num2; break;
			case "/": result = num1 / num2; break;
			case "*": result = num1 * num2; break;
		}
		
		Console.WriteLine("Hasilnye : " + result);
	}
	
	// ------- personality ------- 
	
	public void BeingHuman()
	{
		Console.WriteLine(name + " is galo Aku memang manusia biasa... Being human");
	}
	public void ChangeName()
	{
		Console.Write("Nama Baru : ");
		this.name = Console.ReadLine();
		Console.WriteLine("jenengku ganti dadi " + name + " wak!");
	}
	
	// ------- added method ------- 
	
	public void GetName()
	{
		Console.WriteLine(name);
	}
}
