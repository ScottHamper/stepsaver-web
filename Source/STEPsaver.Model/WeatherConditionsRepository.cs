using Dapper;
using System.Data;
using System.Linq;

namespace STEPsaver.Model
{
    public class WeatherConditionsRepository : IWeatherConditionsRepository
    {
        private IDbConnection connection;

        public WeatherConditionsRepository(IDbConnection connection)
        {
            this.connection = connection;
        }

        public WeatherConditions GetCurrent()
        {
            return connection.Query<WeatherConditions>(@"
                SELECT
                    outdoortemp as Temperature,
                    OutdoorRH as RelativeHumidity,
                    lightlevel as SunlightIntensity,
                    windspeed as WindSpeed,
                    winddir as WindDirection,
                    rain as IsRaining,
                    accumsun as AccumulativeSunlight,
                    TimeStamp as Timestamp
                FROM dbo.wcweather
                ORDER BY TimeStamp DESC")
            .AsList()
            .FirstOrDefault();
        }
    }
}
