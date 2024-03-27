using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models.Entities;

namespace Student_Management_System.Data
{
    public class ApplicationDBContext: DbContext
    {
        //used in program.cs file
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        //DbSet is a table in sql language
        public DbSet<Student> Students { get; set; }
    }
}
