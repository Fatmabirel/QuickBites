using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult NotFound404Page()
        {
            return View();
        }
    }
}
