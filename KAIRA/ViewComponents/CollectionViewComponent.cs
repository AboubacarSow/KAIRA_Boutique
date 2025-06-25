using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class CollectionViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}
