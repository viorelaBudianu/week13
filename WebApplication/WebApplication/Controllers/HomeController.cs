using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // simulate go to database
            var model = new UserViewModel() { Email = "andrei@yahoo.com", UserName = "andrei"  };

            return View(model);
        }
    }
}