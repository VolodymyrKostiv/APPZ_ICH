using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Entities.Vacancy
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime CreationTime { get; set; }
        public int Salary { get; set; }
        public string Company { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public ICH.DAL.Entities.User.User User { get; set; }
    }
}
