using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
