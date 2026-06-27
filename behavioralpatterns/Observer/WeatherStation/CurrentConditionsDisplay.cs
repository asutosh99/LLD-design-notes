namespace BehavioralPatterns.Observer.WeatherStation;

public class CurrentConditionsDisplay : IWeatherObserver
{
    private readonly IWeatherObservable _weatherStation;

    public CurrentConditionsDisplay(IWeatherObservable weatherStation)
    {
        _weatherStation = weatherStation;
        weatherStation.AddObserver(this);
    }

    public void Update()
    {
        Console.WriteLine("Saving weather data... ");
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current Weather Conditions: " + _weatherStation);
    }
}
