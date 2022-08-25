using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    public class Product : Controller
    {
        public IActionResult List(string cat, int num)
        {
            return Content("Product Controller, List Action, " + 
                "Category = " + cat + ", Page = " + num);
        }

        public IActionResult Detail(int id)
        {
            return Content("Product Controller, Detail Action, ID = " + id);
        }
    }
}
