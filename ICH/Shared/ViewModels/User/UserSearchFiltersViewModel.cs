using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Shared.ViewModels.User
{
    public class UserSearchFiltersViewModel
    {
        public string? SearchName { get; set; }
        public LocationViewModel? SelectedLocation { get; set; }
        public IEnumerable<CategoryViewModel>? SelectedCategories { get; set; }
        public IEnumerable<SpecialCategoryViewModel>? SelectedSpecialCategories { get; set; }
        public IEnumerable<EmploymentTypeViewModel>? SelectedEmploymentTypes { get; set; }
        public IEnumerable<WorkTypeViewModel>? SelectedWorkTypes { get; set; }
    }
}
