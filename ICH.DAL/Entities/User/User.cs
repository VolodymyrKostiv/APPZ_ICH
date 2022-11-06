using ICH.DAL.Entities.Vacancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Entities.User
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }

        public UserType UserType { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public ICollection<ICH.DAL.Entities.Vacancy.Vacancy> Vacancies { get; set; }
    }
}
