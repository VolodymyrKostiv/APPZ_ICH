using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.Interfaces.Vacancy
{
    public interface IVacancyService
    {
        Task<IEnumerable<VacancyDTO>> GetAllVacanciesAsync();
        Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(string searchName, string filter, string sort);
        Task<VacancyDTO> GetVacancyByIdAsync(int id);
    }
}
