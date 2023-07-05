namespace BankLib;

public class Bank
{
	private string _name, _password;
	private double _balance{ get; set;} // properties
	
	public Bank(string name, double balance, string password)
	{
		_name = name;
		_password = password;
		if (balance > 0)
		{
			_balance = balance;
		}
		else
		{
			_balance = 0;
			Console.WriteLine("Semangat mencari duid!");
		}
	}
	
	public static double TotalBalance()
	{
		Bank bankInstance = new Bank("miki",1000,"miki123"); // trial another way to access the var
		return bankInstance._balance;
	}
	
	public double ReqBalance(string password)
	{
		if(password == _password)
		{
			return _balance;
		}
		return 0;
	}
	
	public string SetPass(string oldpass, string newpass)
	{
		if(oldpass == _password)
		{
			_password = newpass;
			return "Password keganti";
		}
		else
		{
			return "Password lama salah";
		}
	}
	
	public double SetBalance(double change)
	{
		_balance += change;
		return _balance;
	}
}
