using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.Interfaces.Vacancy
{
    public interface IVacancyService
    {
        Task<IEnumerable<VacancyDTO>> GetAllVacancies();
    }
}
