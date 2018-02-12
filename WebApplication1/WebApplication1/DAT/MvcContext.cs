using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAT
{
    public class MvcContext : DbContext
    {

        public MvcContext():base("Ogrenciveritabani")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Sınıf> Sınıflar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}