namespace Week2Day5;

class Program
{
	static void Main()
	{
		// --- CONVERSION ---
		System.Console.WriteLine("--- CONVERSION ---");
		
		// hexa to int
		int hexint = Convert.ToInt32("2D",16);
		System.Console.WriteLine(hexint);
		
		// dynamic
		dynamic myint = 123;
		myint = "456";
		System.Console.WriteLine(myint);
		
		// data types using ChangeType
		Type toType = typeof(double);
		object from = "67";
		object to = Convert.ChangeType(from, toType);
		System.Console.WriteLine(to);
		System.Console.WriteLine(to.GetType());
		
		// double to byte array using BitConverter
		byte[] myBytes = new byte[8];
		myBytes = BitConverter.GetBytes(654.321);
		foreach (var b in myBytes)
		{
			System.Console.Write(b + " ");
		}
		System.Console.WriteLine("");
		
		// byte array to double
		double db = BitConverter.ToDouble(myBytes,0); // 0 starting index
		System.Console.WriteLine(db);
		
		
		// --- DATETIME ---
		System.Console.WriteLine("");
		System.Console.WriteLine("--- DATETIME ---");
		
		// initializing datetime
		DateTime someDay = new DateTime(2023,6,1,0,0,0);
		DateTime anotherDay = new DateTime(2023,8,26,0,0,0);
		
		// difference bween 2 datetime
		TimeSpan diff = anotherDay - someDay;
		System.Console.WriteLine(diff.TotalDays);
		
		// timezone info
		TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
		System.Console.WriteLine(tz);
		
		
		// --- EQUAL ---
		System.Console.WriteLine("");
		System.Console.WriteLine("--- EQUAL ---");
		
		// simple equal
		string str1 = "sugiono";
		string str2 = "sugiono";
		bool isEqual = str1.Equals(str2);
		System.Console.WriteLine(str1 == str2);
		System.Console.WriteLine(isEqual);
		
		// useful Equals
		object str3 = "sugiono";
		char[] names = {'s','u','g','i','o','n','o'};
		object str4 = new string(names);
		System.Console.WriteLine(str3 == str4);
		System.Console.WriteLine(str3.Equals(str4));
		
	}
}

public class theClass
{
	private int id;
}