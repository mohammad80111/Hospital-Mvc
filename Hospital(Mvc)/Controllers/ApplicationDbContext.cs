using Hospital_Mvc_.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Mvc_.Controllers
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
