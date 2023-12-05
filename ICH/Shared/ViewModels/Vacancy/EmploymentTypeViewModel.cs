using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class EmploymentTypeViewModel
    {
        public int EmploymentTypeId { get; set; }
        public string Title { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }
        //public ICollection<UserInfoViewModel> UserInfos { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EmploymentTypeViewModel model &&
                   EmploymentTypeId == model.EmploymentTypeId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EmploymentTypeId, Title);
        }
    }
}
