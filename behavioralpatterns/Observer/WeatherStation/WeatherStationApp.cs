namespace BehavioralPatterns.Observer.WeatherStation;

public class WeatherStationApp
{
    public static void Run()
    {
        Console.WriteLine("###### Observer Design Pattern ######");

        IWeatherObservable weatherStation = new WeatherStation();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherStation);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

        Console.WriteLine("===>>> Initial Weather Update");
        weatherStation.SetWeatherReadings(80, 65, 30.4f);

        Console.WriteLine("===>>> Second Weather Update");
        weatherStation.SetWeatherReadings(82, 70, 29.2f);

        weatherStation.RemoveObserver(forecastDisplay);

        Console.WriteLine("===>>> Third Weather Update");
        weatherStation.SetWeatherReadings(70, 21, 29.2f);
    }
}
