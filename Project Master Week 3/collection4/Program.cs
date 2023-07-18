using System.Collections;

class Program
{
	static void Main()
	{
		// ----- HASHTABLE -----
		var hashtable = new Hashtable();
		
		hashtable.Add(1, "stunggal");
		hashtable.Add("kalih", 2);
		hashtable.Add(3, true);
		
		System.Console.WriteLine(hashtable[1]); // stunggal
		System.Console.WriteLine(hashtable[2]); // empty
		System.Console.WriteLine(hashtable[3]); // true
		System.Console.WriteLine(hashtable[false]); // empty
		
		// ----- DICTIONARY -----
		
	}
}