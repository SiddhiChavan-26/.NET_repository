using Microsoft.EntityFrameworkCore;

namespace StudentCRUDapp.Data
{
    public class AppDbContext : DbContext //connects app and Database
    {
        public DbSet<Student> Students {get; set;} //student table call and object created Students

        //automatically created in visual studio
        //in built method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;"
            );
        }
    }
}
