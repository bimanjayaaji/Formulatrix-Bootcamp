namespace observerDS;

interface ISubject 
{
	void Attach(IObserver observer);
	void Detach(IObserver observer);
	void Notify();
}

interface IObserver
{
	string? GetDesc();
	void Update(ISubject subject);
}

class WeatherStation : ISubject // subject / publisher
{
	private double _temperature;
	private List<IObserver> _observers = new();

	public double Temperature
	{
		get { return _temperature; }
		set
		{
			_temperature = value;
			Notify();
		}
	}

	public void Attach(IObserver observer)
	{
		_observers.Add(observer);
		Console.WriteLine($"New subscriber added : {observer.GetDesc()}");
	}

	public void Detach(IObserver observer)
	{
		_observers.Remove(observer);
		Console.WriteLine($"Subscriber removed : {observer.GetDesc()}");
	}

	public void Notify()
	{
		foreach (var observer in _observers)
		{
			observer.Update(this); // returning itself
		}
	}
}

class TemperatureDisplay : IObserver
{
	private string? _description = "Temperature Display";
	
	public string? GetDesc()
	{
		return _description;
	}
	
	public void Update(ISubject subject)
	{
		WeatherStation? weatherStation = subject as WeatherStation;
		if (weatherStation != null)
		{
			if (weatherStation.Temperature > 45)
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("DANGER! Current temperature is " + weatherStation.Temperature + "°C");
				Console.ResetColor();
			}
		}
	}
}

class PhoneWidget : IObserver
{
	private string? _description = "Phone Widget";
	
	public string? GetDesc()
	{
		return _description;
	}
	
	public void Update(ISubject subject)
	{
		WeatherStation? weatherStation = subject as WeatherStation;
		if (weatherStation != null)
		{
			Console.WriteLine($"Phone Widget Real Time Temperature : {weatherStation.Temperature}°C");
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		WeatherStation weatherStation = new();
		TemperatureDisplay temperatureDisplay = new();
		PhoneWidget phoneWidget = new();

		weatherStation.Attach(temperatureDisplay);
		weatherStation.Attach(phoneWidget);

		weatherStation.Temperature = 25.0;
		weatherStation.Temperature = 28.5;
		weatherStation.Temperature = 50.0;

		weatherStation.Detach(phoneWidget);

		weatherStation.Temperature = 30.2;
	}
}
