using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class VacancyViewModel
    {
        public int VacancyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public LocationViewModel? Location { get; set; }
        public DateTime CreationTime { get; set; }
        public int? Salary { get; set; }
        public string? Company { get; set; }
        public EmploymentTypeViewModel EmploymentType { get; set; }
        public UserViewModel User { get; set; }
        public ICollection<SpecialCategoryViewModel> SpecialCategories { get; set; }
    }
}
