using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class SpecialCategoryViewModel
    {
        public int SpecialCategoryId { get; set; }
        public string Title { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }
        //public ICollection<UserInfoViewModel> UserInfos { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is SpecialCategoryViewModel model &&
                   SpecialCategoryId == model.SpecialCategoryId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SpecialCategoryId, Title);
        }
    }
}
