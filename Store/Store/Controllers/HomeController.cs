using Microsoft.AspNetCore.Mvc;


namespace Store.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good morning" : "Good Afrtermoon";
            return View("MyView", viewModel);
        }
    }
}