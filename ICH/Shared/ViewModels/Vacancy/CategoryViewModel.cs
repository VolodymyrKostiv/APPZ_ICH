using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }
        //public ICollection<UserInfoViewModel> UserInfos { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CategoryViewModel model &&
                   CategoryId == model.CategoryId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CategoryId, Title);
        }
    }
}
