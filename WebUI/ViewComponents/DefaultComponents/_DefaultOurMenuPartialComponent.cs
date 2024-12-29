using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
