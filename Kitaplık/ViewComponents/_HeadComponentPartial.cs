using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
