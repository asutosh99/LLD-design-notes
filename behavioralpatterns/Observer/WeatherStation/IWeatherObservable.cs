namespace BehavioralPatterns.Observer.WeatherStation;

public interface IWeatherObservable
{
    void AddObserver(IWeatherObserver observer);
    void RemoveObserver(IWeatherObserver observer);
    void NotifyObservers();
    void SetWeatherReadings(float temperature, float humidity, float pressure);
}
