using Microsoft.AspNetCore.Mvc;
using STEPsaver.Model;

namespace STEPsaver.Website.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        IWeatherConditionsRepository conditionsRepository;

        public HomeController(IWeatherConditionsRepository conditionsRepository)
        {
            this.conditionsRepository = conditionsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(conditionsRepository.GetCurrent());
        }
    }
}
