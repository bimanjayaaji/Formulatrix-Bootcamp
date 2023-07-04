using EmployeeLibrary;
using DisplayLib;
class Program 
{
	static void Main() 
	{
		Employee employee = new Employee("yusuf",1000);
		//string name = employee._name;
		string namaEmployee = employee.GetName("password");

		bool nameEmployee = employee.SetName("januar");
		if(nameEmployee) 
		{
			Display.PrintRest("nama sesuai");
		}
		else 
		{
			Display.PrintRest("name tidak sesuai");
		}
		Console.Write("");

		employee.Age = "1";
		Display.PrintRest(employee.Age);

		employee.Age2 = "2";
		Display.PrintRest(employee.Age2);
		
		decimal salary = employee.GetSalary();
		Display.PrintRest("Employee salary : " + salary);
	}
}