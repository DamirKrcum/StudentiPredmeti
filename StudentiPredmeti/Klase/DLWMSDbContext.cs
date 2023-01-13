using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiPredmeti.Klase
{
    public class DLWMSDbContext: DbContext
    {
        private string dbPutanja;
        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["DLWMSPutanja"].ConnectionString;
            //dbPutanja = "DLWMS.db";
        }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentPredmet> StudentiPredmeti { get; set; }

    }
}
