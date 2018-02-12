using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sınıf
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}