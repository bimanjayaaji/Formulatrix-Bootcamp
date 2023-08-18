class WeatherStation
{
	public event EventHandler<double> TemperatureChanged;
	private double _temperature;

	public double Temperature
	{
		get { return _temperature; }
		set
		{
			_temperature = value;
			OnTemperatureChanged(_temperature);
		}
	}

	private void OnTemperatureChanged(double newTemperature)
	{
		TemperatureChanged?.Invoke(this, newTemperature);
	}
}

class TemperatureDisplay
{
	public TemperatureDisplay(WeatherStation weatherStation)
	{
		weatherStation.TemperatureChanged += HandleTemperatureChange;
	}

	private void HandleTemperatureChange(object sender, double newTemperature)
	{
		Console.WriteLine($"Temperature Display: Current temperature is {newTemperature}°C");
	}
}

class PhoneWidget
{
	public PhoneWidget(WeatherStation weatherStation)
	{
		weatherStation.TemperatureChanged += HandleTemperatureChangePW;
	}
	
	private void HandleTemperatureChangePW(object sender, double newTemperature)
	{
		Console.WriteLine($"Phone Widget: Current temperature is {newTemperature}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		WeatherStation weatherStation = new WeatherStation();
		TemperatureDisplay temperatureDisplay = new TemperatureDisplay(weatherStation);
		PhoneWidget phoneWidget = new PhoneWidget(weatherStation);

		weatherStation.Temperature = 25.0;
		weatherStation.Temperature = 28.5;
	}
}
