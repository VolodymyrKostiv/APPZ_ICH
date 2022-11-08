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

        public VacancyService(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;  
        }

        public async Task<IEnumerable<VacancyDTO>> GetAllVacanciesAsync()
        {
            var vacancies = await _repoWrapper.VacancyRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);
        }

        public Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(string searchName, string filter, string sort)
        {
            throw new NotImplementedException();
        }

        public Task<VacancyDTO> GetVacancyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
