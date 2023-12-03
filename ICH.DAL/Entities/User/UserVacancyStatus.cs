using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Entities.User
{
    public class UserVacancyStatus
    {
        [Key]
        public int UserVacancyStatusId { get; set; }

        public string Title { get; set; }
        public ICollection<UserVacancies> Vacancies { get; set; }
    }
}
