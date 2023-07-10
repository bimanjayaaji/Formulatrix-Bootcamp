namespace Week2Day1;

class Program
{	
	public static RobotPos pos = new RobotPos(30,30,0); // initial position
	public static RobotLocalVel localVel = new RobotLocalVel(0,0,0); // initial localVel
	public static RobotGlobalVel globalVel = new RobotGlobalVel(0,0,0); // initial globalVel
	public static GoalCoor goal = new GoalCoor(100,0); // default goal position
	
	public delegate void KickingDelegate();
	
	static void Main()
	{		
		LocalStrategy();
	}
	
	static void LocalStrategy()
	{
		Stop(ref localVel);
		GoToPoint(30, 40);
		FacingGoal(in pos, in goal, out double theta);
		
		KickingDelegate kickingDelegate = Robot1Kicking; // all robot are kicking
		kickingDelegate += Robot2Kicking;
		kickingDelegate();
	}
	
	static void Stop (ref RobotLocalVel lVel)
	{
		lVel.velX = 0;
		lVel.velY = 0;
		lVel.velTheta = 0;
		Console.WriteLine(RobotStatus.Robot_Stopping);
	}
	
	static void GoToPoint(int targetX, int targetY)
	{
		Console.WriteLine(RobotStatus.Robot_GoingToPoint + $" ({targetX},{targetY})");
	}
	
	static void FacingGoal(in RobotPos pos, in GoalCoor goal, out double theta)
	{
		theta = Math.Atan2((goal.goalY - pos.coorY),(goal.goalX - pos.coorX));
		Console.WriteLine(RobotStatus.Robot_FacingGoal + $" theta: {theta}");
	}
	
	static void Robot1Kicking() // for the sake of delegating
	{
		Console.WriteLine("Robot 1 is kicking");
	}
	
	static void Robot2Kicking()
	{
		Console.WriteLine("Robot 2 is kicking");
	}
}

//ROBOT VAR PARAM
struct RobotPos
{
	public double coorX;
	public double coorY;
	public double coorTheta;
	public RobotPos(double x, double y, double theta)
		{
			coorX = x;
			coorY = y;
			coorTheta = theta;
		}
}
struct RobotLocalVel
{
	public double velX;
	public double velY;
	public double velTheta;
	public RobotLocalVel(double x, double y, double theta)
		{
			velX = x;
			velY = y;
			velTheta = theta;
		}
}
struct RobotGlobalVel
{
	public double velX;
	public double velY;
	public double velTheta;
	public RobotGlobalVel(double x, double y, double theta)
		{
			velX = x;
			velY = y;
			velTheta = theta;
		}
}
struct GoalCoor
{
	public double goalX;
	public double goalY;
	public GoalCoor(double x, double y)
		{
			goalX = x;
			goalY = y;
		}
}

// ROBOT STATUS
enum RobotStatus
{
	Robot_Stopping,
	Robot_GoingToPose,
	Robot_GoingToPoint,
	Robot_GoingToBall,
	Robot_FacingGoal,
	Robot_KickingBall,
	Robot_FollowingBall
}