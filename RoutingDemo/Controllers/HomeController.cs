using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Home");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("About");
        }

        public IActionResult Display (string id)
        {
            if (id == null)
                return Content("No ID supplied");
            else
                return Content("Id is " + id);
        }

        [Route("[action]/{start}/{end?}/{message?}")] //The arguments in the route and in the method must be the same
        public IActionResult Countdown(int start, int end = 0, string messege = "")
        {
            string contentString = "Counting down: \n";
            for (int i = start; i >= end; i--)
            {
                contentString += i + "\n";
            }
            contentString += messege;
            return Content(contentString);
        }
    }
}
