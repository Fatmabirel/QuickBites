using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOfferPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
