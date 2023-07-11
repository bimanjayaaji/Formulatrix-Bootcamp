// on progress

namespace Week2Day1;

public delegate void RobotEventHandler(object sender, RobotEventArgs e);

public class Program
{
	public static void Main()
	{
		Robot robot = new Robot();
		SubsWheel wheel = new SubsWheel();
		SubsCamera cam = new SubsCamera();
		SubsContainer cont = new SubsContainer();
		SubsSpatula spat = new SubsSpatula();
		
		robot.RockNotDetected += wheel.HandleEvent;
		robot.RockNotDetected += cam.HandleEvent;
		robot.RockDetected += wheel.HandleEvent;
		robot.RockDetected += cam.HandleEvent;
		robot.ContainerPrepared += cont.HandleEvent;
		robot.RockPickedUp += spat.HandleEvent;

		robot.RobotGo();
	}	
}

// public class RobotStrategy()
// {
// 	// event:(rock not detected) 						rock0
// 	//		action:(wheel moving, camera moving)
// 	// event:(rock detected) 							rock1
// 	// 		action1:(wheel stopping, camera stopping)
// 	// 		action2:(preparing container)
// 	// event:(container prepared) 						container1
// 	// 		action:(spatula picking up rock)
// 	// event:(rock picked up) 							rock3
// 	//		action:(wheel moving, camera moving)
// }

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
	public event RobotEventHandler RockNotDetected;
	public event RobotEventHandler RockDetected;
	public event RobotEventHandler ContainerPrepared;
	public event RobotEventHandler RockPickedUp;
	
	public void RobotGo()
	{
		OnRockNotDetected();
		OnRockDetected();
		OnContainerPrepared();
		OnRockPickedUp();
	}
	
	protected virtual void OnRockNotDetected()
	{
		RockNotDetected?.Invoke(this,new RobotEventArgs("rock0"));
	}
	
	protected virtual void OnRockDetected()
	{
		RockDetected?.Invoke(this,new RobotEventArgs("rock1"));
	}
	
	protected virtual void OnContainerPrepared()
	{
		ContainerPrepared?.Invoke(this,new RobotEventArgs("container1"));
	}
	
	protected virtual void OnRockPickedUp()
	{
		RockPickedUp?.Invoke(this,new RobotEventArgs("rock3"));
	}
}

public class SubsWheel
{
	public void HandleEvent(object sender, RobotEventArgs e)
	{
		if (e.Message == "rock1")
		{
			Console.WriteLine("Wheel Stopping");
		} 
		else
		{
			Console.WriteLine("Wheel Moving");
		}
	}
}

public class SubsCamera
{
	public void HandleEvent(object sender, RobotEventArgs e)
	{
		if (e.Message == "rock1")
		{
			Console.WriteLine("Camera Stopping");
		} 
		else
		{
			Console.WriteLine("Camera Moving");
		}
	}
}

public class SubsContainer
{
	public void HandleEvent(object sender, RobotEventArgs e)
	{
		if (e.Message == "rock1")
		{
			Console.WriteLine("Preparing Container");
		}
		else
		{
			Console.WriteLine("Container Closed");
		}
	}
}

public class SubsSpatula
{
	public void HandleEvent(object sender, RobotEventArgs e)
	{
		if (e.Message == "container1")
		{
			Console.WriteLine("Spatula picking up rock");
		}
		else
		{
			Console.WriteLine("Spatula On idle");
		}
	}
}
