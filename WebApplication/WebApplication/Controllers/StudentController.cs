using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<StudentsViewModel> students = new List<StudentsViewModel>
        {
            new StudentsViewModel { Nume="Ionescu",Prenume="Ana",DataNasterii=new DateTime(2001, 12, 25),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel { Nume="Popescu",Prenume="Ion",DataNasterii=new DateTime(1993, 10, 25),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel { Nume="Vasilescu",Prenume="Gica",DataNasterii=new DateTime(2000, 12, 15),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
        };
        // GET: Student
        public ActionResult Index()
        {
            int s=students.Count();
            return View(s);
        }

        [HttpGet]
        public ActionResult Add ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent()

        {
            var student = new StudentsViewModel();
            students.Add(student);

            return RedirectToAction("Index");
        }

        
    }
}