using System;

namespace STEPsaver.Model
{
    public class WeatherConditions
    {
        public int Temperature { get; set; }
        public int RelativeHumidity { get; set; }
        public int SunlightIntensity { get; set; }
        public int WindSpeed { get; set; }
        public WindDirection WindDirection { get; set; }
        public bool IsPrecipitating { get; set; }
        public int AccumulativeSunlight { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
