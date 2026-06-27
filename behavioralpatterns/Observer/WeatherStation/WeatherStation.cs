namespace BehavioralPatterns.Observer.WeatherStation;

public class WeatherStation : IWeatherObservable
{
    private readonly List<IWeatherObserver> _observers = new();
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public void AddObserver(IWeatherObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine("[+] Observer registered: " + observer.GetType().Name);
    }

    public void RemoveObserver(IWeatherObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("[-] Observer removed: " + observer.GetType().Name);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void SetWeatherReadings(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        NotifyObservers();
    }

    public float GetTemperature() => _temperature;
    public float GetHumidity() => _humidity;
    public float GetPressure() => _pressure;

    public override string ToString()
    {
        return $"WeatherStation{{temperature={_temperature}, humidity={_humidity}, pressure={_pressure}}}";
    }
}
