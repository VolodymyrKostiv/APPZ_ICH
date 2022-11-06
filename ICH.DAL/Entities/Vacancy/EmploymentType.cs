using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public ICollection<ICH.DAL.Entities.Vacancy.Vacancy> Vacancies { get; set; }
    }
}
