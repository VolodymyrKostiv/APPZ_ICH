using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class EmploymentTypeViewModel
    {
        public int EmploymentTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyViewModel> Vacancies { get; set; }
        public ICollection<UserInfoViewModel> UserInfos { get; set; }

    }
}
