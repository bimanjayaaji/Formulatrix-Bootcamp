namespace Static;

public class Calculator
{
	static int calcSize;
	int calcSizeNotStatic;
	
	public Calculator(int calcSizeNotStatic) {
		this.calcSizeNotStatic = calcSizeNotStatic;
		//this.calcSize  = calcSize; //error
		calcSize = calcSizeNotStatic;
	}
	
	public static int Add(int a, int b) 
	{
		return a * b;
	}
	public int ReturnSize() 
	{
		return calcSize;
		//return calcSizeNotStatic; //not error
	}
	
	static public int ReturnSizeCalc() 
	{
		//return calcSizeNotStatic; //error
		return calcSize;
	}
}
