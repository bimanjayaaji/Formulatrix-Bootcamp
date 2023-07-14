namespace Week2Day2;

public delegate void RobotEventHandler(object sender, RobotEventArgs e);

public class Program
{
	public static void Main()
	{
		Robot robot = new Robot();
		Subscriber subscriber = new Subscriber();

		robot.RobotEvent += subscriber.HandleEvent;
		robot.PerformTask("Task 1");

		robot.RobotEvent -= subscriber.HandleEvent;

		robot.PerformTask("Task 2");
	}
}

public class RobotEventArgs : EventArgs
{
	public string Message { get; set; }

	public RobotEventArgs(string message)
	{
		Message = message;
	}
}

public class Robot
{
	public event RobotEventHandler? RobotEvent;

	public void PerformTask(string task)
	{
		try
		{
			Console.WriteLine($"Performing task: {task}");
			
			//throw new Exception("Something went wrong!");

			RobotEventArgs robot1 = new RobotEventArgs("Task completed successfully.");
			OnRobotEvent(robot1);
		}
		catch (Exception ex)
		{
			RobotEventArgs robot1 = new RobotEventArgs($"Error: {ex.Message}");
			OnRobotEvent(robot1);
		}
	}

	protected virtual void OnRobotEvent(RobotEventArgs e)
	{
		RobotEvent?.Invoke(this, e);
	}
}

public class Subscriber
{
	public void HandleEvent(object sender, RobotEventArgs e)
	{
		Console.WriteLine($"Event received: {e.Message}");
	}
}

