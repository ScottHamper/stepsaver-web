using Microsoft.AspNetCore.Mvc;
using STEPsaver.Website.Models.Errors;

namespace STEPsaver.Website.Controllers
{
    [Route("errors")]
    public class ErrorsController : Controller
    {
        [Route("{code}")]
        public IActionResult HttpStatus(int code)
        {
            return View(new HttpStatusModel(code));
        }
    }
}
