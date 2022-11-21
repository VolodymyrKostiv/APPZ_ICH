using ICH.BLL.DTOs.Vacancy;
using ICH.CommonModels.Filters.Vacancy;

namespace ICH.BLL.Interfaces.Vacancy
{
    public interface IVacancyService
    {
        Task<IEnumerable<VacancyDTO>> GetAllVacanciesAsync();
        Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(VacancyFilters filters);
        Task<VacancyDTO> GetVacancyByIdAsync(int id);
    }
}
