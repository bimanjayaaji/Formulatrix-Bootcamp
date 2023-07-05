using BankLib;

class Program
{
	static void Main()
	{
		// set account
		Bank bank = new Bank("miki",1000,"miki123");
		
		// req balance
		double balance = bank.ReqBalance("miki123");
		Console.WriteLine(balance);
		
		// change pass
		string response = bank.SetPass("miki123","miki12345");
		Console.WriteLine(response);
		
		// set balance
		balance = bank.SetBalance(-300);
		balance = bank.SetBalance(800);
		Console.WriteLine(balance);
		
		// static total balance
		double staticTot = Bank.TotalBalance();
		Console.WriteLine("static totBalance : " + staticTot);
	}
}