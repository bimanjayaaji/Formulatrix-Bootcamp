using System.IO;
using System.Text;

class Program
{
	static string path = @".\file.txt";

	static void Main() // Accessing and Displaying File Info            
	{
		FileInfo fileInfo = new FileInfo(path);
		
		Console.WriteLine("File Created on : " + fileInfo.CreationTime);
		Console.WriteLine("Directory Name : " + fileInfo.DirectoryName);
		Console.WriteLine("Name of File : " + fileInfo.Name);
		Console.WriteLine("Full Name of File : " + fileInfo.FullName);
		Console.WriteLine("Length of File : " + fileInfo.Length);
		Console.WriteLine("Is Readonly : " + fileInfo.IsReadOnly);
		Console.WriteLine("File is Last Accessed on : " + fileInfo.LastAccessTime);
	}
	
	static void Main8() // make a new file using file info
	{
		FileInfo fileInfo = new FileInfo(path);
		StreamWriter str = fileInfo.CreateText(); // overwrite
		str.WriteLine("Hello");
		Console.WriteLine("File has been created with text");
		str.Close();
		Console.ReadKey();
	}

	static void Main7() // creating file info
	{
		FileInfo fileInfo = new FileInfo(path);
		fileInfo.Create();
		{
			Console.WriteLine("fileInfo has been created");
		}
	}

	static void Main6() // STREAMREADER ReadToEnd
	{
		using (StreamReader reader = new StreamReader(path))
		{
			Console.WriteLine(reader.ReadToEnd());
		}
	}

	static void Main5() // STREAMWRITER AND STREAMREADER
	{
		// write data
		using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Append))) // fs declared in the scope of sw
		{
			writer.WriteLine("Written from StreamWriter");
			writer.WriteLine("Another line from StreamWriter");
		}

		// read data
		using (StreamReader reader = new StreamReader(File.Open(path, FileMode.Open)))
		{
			string theLine;
			while ((theLine = reader.ReadLine()) != null)
			{
				Console.WriteLine(theLine);
			}
		}
	}

	static void Main4() // STREAMREADER
	{
		using (FileStream fs = new FileStream(path, FileMode.Open))
		using (StreamReader reader = new StreamReader(fs)) // passed to stream reader
		{
			string? myLine;
			while ((myLine = reader.ReadLine()) != null)
			{
				Console.WriteLine(myLine);
			}
		}
	}

	static void Main3()
	{
		using (FileStream fs = new FileStream(path, FileMode.Open)) // reading txt file
		{
			byte[] buffer = new byte[fs.Length];
			fs.Read(buffer, 0, buffer.Length);
			string body = Encoding.UTF8.GetString(buffer);
			Console.WriteLine(body);
		}
	}

	static void Main2() // Writing string to txt using FileStream
	{
		using (FileStream fileStream = new FileStream(path, FileMode.Append))
		{
			byte[] byteData = Encoding.Default.GetBytes("Converting string to bytes");
			fileStream.Write(byteData, 0, byteData.Length);
			fileStream.Close(); // just to be safe
		}
		Console.WriteLine("Successfully write to file");
	}

	static void Main1() // ordinary FileStream.Create
	{
		using (FileStream fileStream = new FileStream(path, FileMode.Create))
		{
			fileStream.Close();
		}
		Console.WriteLine("File has been created");
	}
}