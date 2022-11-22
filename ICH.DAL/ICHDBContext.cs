using ICH.DAL.Entities.General;
using ICH.DAL.Entities.User;
using ICH.DAL.Entities.Vacancy;
using Microsoft.EntityFrameworkCore;

namespace ICH.DAL
{
    public class ICHDBContext : DbContext
    {
        public ICHDBContext()
        {
        }

        public ICHDBContext(DbContextOptions<ICHDBContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Location> Locations { get; set; }  
        public DbSet<Category> Categories { get; set; }
        public DbSet<SpecialCategory> SpecialCategories { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
    }
}
