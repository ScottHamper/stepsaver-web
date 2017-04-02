using Microsoft.AspNetCore.Mvc;
using STEPsaver.Model;

namespace STEPsaver.API.Controllers.WeatherConditions
{
    [Route("api/weather-conditions")]
    public class WeatherConditionsController : Controller
    {
        private IWeatherConditionsRepository conditionsRepository;

        public WeatherConditionsController(IWeatherConditionsRepository conditionsRepository)
        {
            this.conditionsRepository = conditionsRepository;
        }

        [HttpGet("[action]")]
        public Model.WeatherConditions Current()
        {
            return conditionsRepository.GetCurrent();
        }
    }
}
