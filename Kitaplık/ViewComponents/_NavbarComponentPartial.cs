using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
