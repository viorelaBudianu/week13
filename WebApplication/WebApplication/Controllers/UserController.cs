using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        private static readonly List<UserViewModel> users = new List<UserViewModel>
        {
            new UserViewModel { Id = 1, Email = "dan@yahoo.com", UserName = "dan" },
            new UserViewModel { Id = 2, Email = "andrei@yahoo.com", UserName = "andrei" },
            new UserViewModel { Id = 3, Email = "vlad@yahoo.com", UserName = "vlad" },
        }; 

        [HttpGet]
        public ActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = users.Where(x => x.Id == id).FirstOrDefault();

            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew()
        {
            var username = Request.Form["username"];
            var email = Request.Form["email"];

            var user = new UserViewModel { Email = email, UserName = username, Id = users.Count + 1 };

            users.Add(user);

            return RedirectToAction("Index");
        }
    }
}