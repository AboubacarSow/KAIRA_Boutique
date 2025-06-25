using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class SubscriptionViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
