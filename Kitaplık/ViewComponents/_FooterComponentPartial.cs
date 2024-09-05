using Microsoft.AspNetCore.Mvc;

namespace Kitaplık.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
