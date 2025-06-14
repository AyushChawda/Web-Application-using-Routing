using Microsoft.AspNetCore.Mvc;

namespace Web_Application__using_Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            // Passing the data with the help of ViewData
            string[] arr=["Shivam", "Pawan", "Abhishek","Shivaay"];
            ViewData["data"] = arr;

            List<string> userName = new List<string> { "Shivam","Gopal","Vaibhav","Suresh","Govind" };
            ViewData["UserList"] = userName;

            // Passing data using viewBag

            ViewBag.name = "Ayush";
            ViewBag.list = arr;

            // Passing data using tempData

            TempData["list"] = new List<string> { "Raghav", "Shruti", "Vishal", "Shivangi" };
            TempData["name"] = "ayush";
            TempData.Keep();

            return View();
        }
        public IActionResult About()
        {
            TempData.Keep();
            return View();
        }
    }
}
