using ICH.DAL.Entities.User;
using ICH.DAL.Entities.Vacancy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
