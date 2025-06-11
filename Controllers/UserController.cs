using Microsoft.AspNetCore.Mvc;

namespace Web_Application__using_Routing.Controllers
{
    [Route("/User")]
    public class UserController : Controller
    {
        // custome Attribute routing 
        
        [Route("/User")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
