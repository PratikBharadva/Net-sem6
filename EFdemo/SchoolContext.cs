using EFdemo;
using Microsoft.EntityFrameworkCore;

namespace EFdemo
{
    public class SchoolContext : DbContext
    {
        internal DbSet<student> students { get; set; }
        internal DbSet<grade> grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database = SchoolDB;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<grade>().HasKey(g => g.gradeid);

            modelBuilder.Entity<student>()
                .HasKey(s => s.studentid);
                
        }
    }

}

