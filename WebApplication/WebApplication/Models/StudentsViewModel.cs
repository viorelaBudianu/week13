using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int ID { get; set; }
        [Display(Name = "Nume")]
        public string Nume { get; set; }
        [Display(Name = "Prenume")]
        public string Prenume { get; set; }
        [Display(Name = "Data Nasterii")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNasterii { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        public Sex Sex { get; set; }
        [Display(Name = "Adresa")]
        public string Adresa { get; set; }
        [Display(Name = "Oras")]
        public string Oras { get; set; }
        [Display(Name ="Cod Postal")]
        public uint CodPostal { get; set; }
        [Display(Name ="Judet")]
        public string Judet { get; set; }
        public const string Tara = "Romania";
        public List<string> Hobbys = new List<string>();

    }
}