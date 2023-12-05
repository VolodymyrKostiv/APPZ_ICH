using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.Interfaces.Vacancy
{
    public interface IVacancyService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<IEnumerable<SpecialCategoryDTO>> GetSpecialCategoriesAsync();
        Task<IEnumerable<LocationDTO>> GetLocationsAsync();
        Task<IEnumerable<WorkTypeDTO>> GetWorkTypesAsync();
        Task<IEnumerable<EmploymentTypeDTO>> GetEmploymentTypesAsync();
        Task<IEnumerable<VacancyDTO>> GetAllVacanciesAsync();
        Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(VacancySearchFiltersDTO filters);
        Task<IEnumerable<VacancyStatusDTO>> GetVacancyStatusesAsync();
        Task AddVacancyAsync(VacancyDTO vacancy);
        Task<VacancyDTO> GetVacancyByIdAsync(int id);
    }
}
