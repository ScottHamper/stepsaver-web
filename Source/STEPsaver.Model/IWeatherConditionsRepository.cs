namespace STEPsaver.Model
{
    public interface IWeatherConditionsRepository
    {
        WeatherConditions GetCurrent();
    }
}
