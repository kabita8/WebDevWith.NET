using Microsoft.EntityFrameworkCore;
public class CollegeDbContext: DbContext
{
    public DbSet<Course> Courses {get; set;}
    public DbSet<Session> Session {get; set;}
 protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
 {
    optionsbuilder.UseSqlite("Data Source=CollegeManagement.db");
 }
}