using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
using ICH.DAL.Repositories.Interfaces.Base;

namespace ICH.BLL.Services.Vacancy
{
    public class VacancyService : IVacancyService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;


        public async Task<IEnumerable<VacancyDTO>> GetAllVacancies()
        {
            var vacancies = await _repoWrapper.VacancyRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);
        }
    }
}
