namespace ICH.BLL.DTOs.Vacancy
{
    public class VacancySearchFiltersDTO
    {
        public string? SearchName { get; set; }
        public LocationDTO? SelectedLocation { get; set; }
        public IEnumerable<CategoryDTO>? SelectedCategories { get; set; }
        public IEnumerable<SpecialCategoryDTO>? SelectedSpecialCategories { get; set; }
        public IEnumerable<EmploymentTypeDTO>? SelectedEmploymentTypes { get; set; }
        public IEnumerable<WorkTypeDTO>? SelectedWorkTypes { get; set; }
    }
}
