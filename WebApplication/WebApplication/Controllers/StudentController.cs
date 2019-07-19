using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<StudentsViewModel> students = new List<StudentsViewModel>
        {
            new StudentsViewModel {ID=1, Nume="Ionescu",Prenume="Ana",DataNasterii=new DateTime(2001, 12, 25),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel {ID=2, Nume="Popescu",Prenume="Ion",DataNasterii=new DateTime(1993, 10, 25),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel {ID=3, Nume="Vasilescu",Prenume="Gica",DataNasterii=new DateTime(2000, 12, 15),Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
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
            student.Nume = Request["Last_Name"]; //aici pun numele inputului
            student.Prenume = Request["First_Name"];
            student.Adresa = Request["Address"];
            student.Email = Request["emailaddress"];
            student.Telefon = Request["Mobile_Number"];
            student.Oras = Request["City"];
            student.Judet = Request["State"];
            //student.Sex = Request["Gender"];
            var zi =Request["Birthday_day"];
            var luna = Request["Birthday_Month"];
            var an = Request["Birthday_Year"];
            student.ID = students.Count + 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(zi+"/"+ luna+"/"+an);
            student.DataNasterii = Convert.ToDateTime(sb);
            students.Add(student);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ViewStudents()
        {
            return View(students);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = students.Where(x => x.ID == id).FirstOrDefault();

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var id = Request.QueryString["id"];
            return View();
        }

        [HttpPost]
        public ActionResult Edit (int id)
        {
            var s = students.Where(x => x.ID == id).FirstOrDefault();
            //if (Request[])
            //    student.Nume = Request["Last_Name"]; //aici pun numele inputului
            //student.Prenume = Request["First_Name"];
            //student.Adresa = Request["Address"];
            //student.Email = Request["emailaddress"];
            //student.Telefon = Request["Mobile_Number"];
            //student.Oras = Request["City"];
            //student.Judet = Request["State"];
            ////student.Sex = Request["Gender"];
            //var zi = Request["Birthday_day"];
            //var luna = Request["Birthday_Month"];
            //var an = Request["Birthday_Year"];
            //student.ID = students.Count + 1;
            //StringBuilder sb = new StringBuilder();
            //sb.Append(zi + "/" + luna + "/" + an);
            //student.DataNasterii = Convert.ToDateTime(sb);
            //students.Add(student);

            return RedirectToAction("Index");
        }
        
    }
}