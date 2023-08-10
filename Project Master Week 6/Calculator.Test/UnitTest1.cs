// using Calculation;

namespace Calculator.Test;

[TestFixture]
public class Tests
{
	private SimpleCalculation calculate;
	
	[SetUp]
	public void Setup()
	{
		calculate = new();
	}

	[Test]
	public void AddTest()
	{
		int a = 10;
		int b = 12;
		int expected = 22;

		int actual = calculate.Add(a, b);

		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void SubstractTest()
	{
		int a = 10;
		int b = 12;
		int expected = -2;

		int actual = calculate.Substract(a, b);

		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void MultiplyTest()
	{
		int a = 10;
		int b = 12;
		int expected = 120;

		int actual = calculate.Multiply(a, b);

		Assert.AreEqual(expected, actual);
	}
	
	[Test]
	public void DivisonTest()
	{
		int a = 10;
		int b = 2;
		int expected = 5;

		int actual = calculate.Division(a, b);

		Assert.AreEqual(expected, actual);
	}
	
	[TestCase(3, 5, 90)]
	[TestCase(0, 0, 0)]
	[TestCase(-10, 10, 0)]
	public void AddTest2(int a, int b, int expected)
	{
		int result = calculate.Add(a, b);
		Assert.AreEqual(expected, result);
	}
}