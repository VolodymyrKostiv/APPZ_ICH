using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class WorkType
    {
        [Key]
        public int WorkTypeId { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
