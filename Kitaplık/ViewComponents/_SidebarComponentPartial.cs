using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.ViewComponents
{
    public class _SidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
    {
        return View();
    }
    }
}
