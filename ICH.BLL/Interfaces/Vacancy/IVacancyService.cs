using ICH.BLL.DTOs.Vacancy;
using ICH.CommonModels.Filters.Vacancy;

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
        Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(VacancyFilters filters);
        Task<VacancyDTO> GetVacancyByIdAsync(int id);
    }
}
