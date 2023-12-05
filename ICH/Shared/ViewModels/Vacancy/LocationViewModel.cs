using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class LocationViewModel
    {
        public int LocationId { get; set; }
        public string Title { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }
        //public ICollection<UserInfoViewModel> UserInfos { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is LocationViewModel model &&
                   LocationId == model.LocationId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LocationId, Title);
        }
    }
}
