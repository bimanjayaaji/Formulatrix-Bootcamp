namespace Bird;

class Program
{
	static void Main()
	{
		// ----- STRUCT TYPE CASE -----
		// int x = 5;
		// int y = x;
		// y = 9;
		
		// Console.WriteLine(x);
		// Console.WriteLine(y);
		
		/*
		hasilnya x = 5, y =9
		 */
		
		
		// ----- REF TYPE CASE -----
		// Parent P = new(5);
		// Parent c = P;
		// c.x = 2;
		
		// Console.WriteLine(P.x);
		// Console.WriteLine(c.x);
		
		/*
		hasilnya 2,2. soalnya yg dibikin baru bukan valuenya tapi address-nya.
		kecuali kita deklarasi c pake --> Parent c = new(2)
		 */
		 
		 
		// ----- STRING TYPE CASE -----
		// string name = "John";
		// name = "Alex";
		
		/*
		proses ini bakal lemot soale string bakal bikin alamat baru
		(ga langsung ngubah value di alamat lama)
		 */
		
		
		// ----- COMPARISON USING DOUBLE -----
		// float x = 0.1f;
		// float y = 0.1f;
		// float z = 0.1f;
		// Console.Write("Float " + x + " + " + y + " + " + z + " : ");
		// // wdyt? kalo dicompare bakal true apa false?
		
		// if (x+y+z == 0.3f)
		// {
		// 	Console.WriteLine(true); 	
		// } else
		// {
		// 	Console.WriteLine(false); 
		// }
		
		// // kalo double?
		// double a = 0.1;
		// double b = 0.1;
		// double c = 0.1;
		// Console.Write("Double " + a + " + " + b + " + " + c + " : ");
		
		// if (a+b+c == 0.3)
		// {
		// 	Console.WriteLine(true); 	
		// } else
		// {
		// 	Console.WriteLine(false); 
		// }
		
		// // kalo decimal
		// decimal o = 0.1m;
		// decimal p = 0.1m;
		// decimal q = 0.1m;
		// Console.Write("Decimal " + o + " + " + p + " + " + q + " : ");
		
		// if (o+p+q == 0.3m)
		// {
		// 	Console.WriteLine(true); 	
		// } else
		// {
		// 	Console.WriteLine(false); 
		// }
		
		// // so the stand out one ==> double
		
		
		// ----- TRIAL STRUCT -----
		// Param1 param1 = new();
		// param1.coorX = 0.1m;
		// param1.coorY = 0.1m;
		// param1.theta = 0.1m;
		
		// Param2 param2 = new();
		// param2.detectedX = 0.3m;
		// param2.detectedY = 0.3m;
		 	
		
		// ----- GENERIC -----
		Closet<string> lemari = new Closet<string>();
		lemari.AddClothes("jersey MU");
		lemari.AddClothes("jersey chelsea");
		lemari.AddClothes("jersey MC");
		lemari.AddClothes("jersey NCU");
		
		Console.WriteLine(" ");
		
		lemari.TakeClothes("jersey MU");
		lemari.GetClosetList();
		
		
		
	}
}

// ----- REF TYPE -----
// class Parent
// 		{
// 			public int x;
			
// 			public Parent(int x)
// 			{
// 				this.x = x;
// 			}
// 		}


// ----- TRIAL STRUCT -----	
// kek class tapi isine parameter tok.
// struct Param1
// {
// 	public decimal coorX;
// 	public decimal coorY;
// 	public decimal theta;
// }

// struct Param2
// {
// 	public decimal detectedX;
// 	public decimal detectedY;
// }


// ----- GENERIC -----
public class Closet<T>
{
	public static List<object> closet = new();
	
	public void AddClothes(T clothe)
	{
		closet.Add(clothe);
		Console.WriteLine("added " + clothe);
	}
	
	public void TakeClothes(T clothe)
	{
		closet.Remove(clothe);
	}
	
	public string GetClosetList()
	{
		string isi="";
		
		foreach (object item in closet)
		{
			isi = item.ToString();
			Console.WriteLine(isi);
		}
		
		return isi;
	}
}