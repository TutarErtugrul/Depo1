using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
       
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int sınıfId { get; set; }
        public virtual Sınıf Sınıf { get; set; }


    }
}