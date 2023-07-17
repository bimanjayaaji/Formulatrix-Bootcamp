using System.Collections;
using System.Diagnostics;
namespace week3day1;

class Program
{
	static void Main()
	{
		// ----- ARRAY -----
		System.Console.WriteLine("---");
		
		// int[] myArray = new int[8];
		// myArray[0] = 0;
		// myArray[1] = 1;
		// myArray[2] = 2;
		// myArray[4] = 4;
		// myArray[5] = 5;
		// foreach (var x in myArray)
		// {
		// 	System.Console.WriteLine(x); // defaultnya yg belom keisi 0
		// }
		
		// System.Console.WriteLine(myArray.ToString()); // ngeprint system.int32
		
		// ----- ARRAYLIST -----
		System.Console.WriteLine("---");
		
		// ArrayList sayurs = new ArrayList();
		
		// sayurs.Add("sayur pisang");
		// sayurs.Add('s');
		// sayurs.Add(123);
		// sayurs.Add(3.303030);
		// //sayurs.Add(List<int>); // error
		// List<int> buah = new List<int>();
		// sayurs.Add(buah);
		// //sayurs.Add(Dictionary<int,string>); // error
		// Dictionary<int,string> myDict = new Dictionary<int,string>();
		// sayurs.Add(myDict);
		
		// foreach (var x in sayurs)
		// {
		// 	System.Console.WriteLine(x);
		// }
		
		// sayurs[3] = "tergantikan";
		// System.Console.WriteLine(sayurs[3]);
		
		// ----- LIST -----
		System.Console.WriteLine("---");
		
		// List<object> obj = new List<object>();
		// obj.Add("ini objek");
		// obj.Add("ini juga objek");
		// obj.Add("masih objek");
		// obj.Add(76);
		
		// foreach (var x in obj)
		// {
		// 	System.Console.Write(x + " | ");
		// 	System.Console.WriteLine(x.GetType());
		// }
		
		// ----- LINKED LIST -----
		System.Console.WriteLine("---");
		
		// int iter = 1000000;
		// LinkedList<int> linkedList = new LinkedList<int>();
		// List<int> list = new List<int>();

		// for (int i = 0; i < iter; i++)
		// {
		// 	linkedList.AddLast(i);
		// }

		// for (int i = 0; i < iter; i++)
		// {
		// 	list.Add(i);
		// }

		// Stopwatch linkedListSW = Stopwatch.StartNew();
		// for (int i = 0; i < iter; i++)
		// {
		// 	int element = linkedList.First.Value;
		// 	linkedList.RemoveFirst();
		// }
		// linkedListSW.Stop();

		// Stopwatch listSW = Stopwatch.StartNew();
		// for (int i = 0; i < iter; i++)
		// {
		// 	int element = list[0];
		// 	list.RemoveAt(0);
		// }
		// listSW.Stop();

		// Console.WriteLine("linkedListSW: " + linkedListSW.Elapsed); // linkedListSW: 00:00:00.0194503
		// Console.WriteLine("listSW: " + listSW.Elapsed); // listSW: 00:02:50.9455432
		
		// ----- HASHSET -----
		System.Console.WriteLine("---");
		
		// List<int> listiyanto = new List<int>();
		// listiyanto.Add(1);
		// listiyanto.Add(1);
		// listiyanto.Add(1);
		// listiyanto.Add(1);
		// HashSet<int> hashbullah  = new HashSet<int>(listiyanto);
		
		// foreach (var x in hashbullah)
		// {
		// 	System.Console.WriteLine(x);
		// }
	}
}