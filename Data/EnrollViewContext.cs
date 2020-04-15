using EnrollView.Models;
using Microsoft.EntityFrameworkCore;

namespace EnrollView.Data
{
    //Creates a new database context named StudentInformationContext
    public class EnrollViewContext : DbContext
    {
        public EnrollViewContext(DbContextOptions<EnrollViewContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}