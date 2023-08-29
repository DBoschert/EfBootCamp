using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfBootCamp
{
    public class BootCampContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public BootCampContext() : base() {  }

        public BootCampContext(DbContextOptions<BootCampContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;database=BootCampDataBase;trusted_connection=true;trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }
    }

    
}
