using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class WorkTypeViewModel
    {
        public int WorkTypeId { get; set; }
        public string Title { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }
        //public ICollection<UserInfoViewModel> UserInfos { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is WorkTypeViewModel model &&
                   WorkTypeId == model.WorkTypeId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(WorkTypeId, Title);
        }
    }
}
