public class UnitTest1
{
	private SimpleCalculation calculate = new();
	
	[Fact]
	public void Test1()
	{
		int a = 10;
		int b = 12;

		// Act
		int result = calculate.Add(a, b);

		// Assert
		Assert.Equal(22, result);
	}
	
	[Fact]
	public void Test2()
	{
		int a = 10;
		int b = 12;

		// Act
		int result = calculate.Substract(a, b);

		// Assert
		Assert.Equal(-2, result);
	}
}