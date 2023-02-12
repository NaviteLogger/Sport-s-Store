using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index() => View();
        public ViewResult Index()
        {
            return View("Index"); //".." defines the name of the file in the Views folder
        }
    }
}