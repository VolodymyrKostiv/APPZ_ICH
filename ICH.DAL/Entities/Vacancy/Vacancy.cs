using ICH.DAL.Entities.General;
using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public Location? Location { get; set; }
        public DateTime CreationTime { get; set; }
        public int? Salary { get; set; }
        public string? Company { get; set; }
        public EmploymentType? EmploymentType { get; set; }
        public WorkType? WorkType { get; set; }
        public Category? Category { get; set; }
        public ICH.DAL.Entities.User.User User { get; set; }
        public ICollection<SpecialCategory>? SpecialCategories { get; set; }
    }
}
