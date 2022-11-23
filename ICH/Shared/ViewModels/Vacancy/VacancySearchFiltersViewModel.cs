namespace ICH.Shared.ViewModels.Vacancy
{
    public class VacancySearchFiltersViewModel
    {
        public string? SearchName { get; set; }  
        public LocationViewModel? SelectedLocation { get; set; }
        public IEnumerable<CategoryViewModel>? SelectedCategories { get; set; }
        public IEnumerable<SpecialCategoryViewModel>? SelectedSpecialCategories { get; set; }
        public IEnumerable<EmploymentTypeViewModel>? SelectedEmploymentTypes { get; set; }
        public IEnumerable<WorkTypeViewModel>? SelectedWorkTypes { get; set; }
    }
}
