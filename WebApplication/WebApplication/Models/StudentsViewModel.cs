using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public enum Sex
    {
        Masculin = 1,
        Feminin=2
    }
    public class StudentsViewModel
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string DataNasterii { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Sex Sex { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public uint CodPostal { get; set; }
        public string Judet { get; set; }
        public const string Tara = "Romania";
        public List<string> Hobbys = new List<string>();

    }
}