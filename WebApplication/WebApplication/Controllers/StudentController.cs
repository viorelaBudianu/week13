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
            new StudentsViewModel { Nume="Ionescu",Prenume="Ana",DataNasterii="10/10/1993",Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel { Nume="Popescu",Prenume="Ion",DataNasterii="10-10-1993",Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
            new StudentsViewModel { Nume="Vasilescu",Prenume="Gica",DataNasterii="10/10/1993",Email="ionescu_ana@yahoo.com",Sex=Sex.Feminin,Telefon="0741669147",Adresa="",Judet="Iasi",Oras="Iasi",CodPostal=89912 },
        };
        // GET: Student
        public ActionResult Index()
        {
            int s=students.Count();
            return View(s);
        }

        
    }
}