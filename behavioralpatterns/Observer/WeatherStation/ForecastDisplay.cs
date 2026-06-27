namespace BehavioralPatterns.Observer.WeatherStation;

public class ForecastDisplay : IWeatherObserver
{
    private readonly IWeatherObservable _weatherStation;

    public ForecastDisplay(IWeatherObservable weatherStation)
    {
        _weatherStation = weatherStation;
        weatherStation.AddObserver(this);
    }

    public void Update()
    {
        Console.WriteLine("Updating weather data to do some analytics: " + _weatherStation);
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Forecast Details: Displaying information about Rain, " +
                "Temperature Trends, Significant Weather Events and other phenomemnon...");
    }
}
