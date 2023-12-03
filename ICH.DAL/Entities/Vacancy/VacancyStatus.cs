using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Entities.Vacancy
{
    public class VacancyStatus
    {
        [Key]
        public int VacancyStatusId { get; set; }   
        public string Title {  get; set; }

        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
