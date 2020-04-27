using FluentAPI.EntityConfiguration;
using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Course>();
                modelBuilder.Configurations.Add(new CourseConfiguration());
            }
        }
    }
}
