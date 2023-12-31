﻿using System.Diagnostics;

class Program
{
	static async Task Main()
	{
		Task task1 = Loading();
		Task task2 = Process();
		Task completed = await Task.WhenAny(task1,task2);
		Console.WriteLine("");
		Console.WriteLine("First completed task: " + (completed == task1 ? "Task 1" : "Task 2"));
	}
	
	static async Task Loading()
	{
		Console.Write("Loading, please wait...");
		string[] animationFrames = new string[] { "\\", "-", "/", "|" }; // there are 2 \ bcs single \ represents other stuff in c#
		while (true)
		{
			for (int i = 0; i < 20; i++)
			{
				string currentFrame = animationFrames[i % animationFrames.Length];
				Console.Write(currentFrame);
				await Task.Delay(250);
				Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
				// cursorleft = column
				// cursortop = row --> why not "row"!? \_(^.^)_/
			}
		}
	}
	
	static async Task Process()
	{
		await Task.Delay(5000);
	}
}