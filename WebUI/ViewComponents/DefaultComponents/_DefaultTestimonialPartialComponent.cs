using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
