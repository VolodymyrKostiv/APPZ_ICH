using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
using ICH.CommonModels.Filters.Vacancy;
using ICH.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
            var vacancies = await _repoWrapper.VacancyRepository.GetAllAsync(
                include: source => source
                    .Include(x => x.EmploymentType));

            return _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);
        }

        public async Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(VacancyFilters filters)
        {
            //Expression<Func<DAL.Entities.Vacancy.Vacancy, bool>> lastPredicate = null;
            //string lowerSearchName = searchName.ToLower();

            //if (searchName != null)
            //{
            //    Expression<Func<DAL.Entities.Vacancy.Vacancy, bool>> searchPredicate = x => x.Title.ToLower().Contains(lowerSearchName);
            //}

            //var vacancies = await _repoWrapper.VacancyRepository.GetAllAsync(
            //    include: source => source
            //        .Include(x => x.EmploymentType),
            //    predicate: lastPredicate);

            return null;
        }

        public async Task<VacancyDTO> GetVacancyByIdAsync(int id)
        {
            var vacancy = await _repoWrapper.VacancyRepository.GetFirstOrDefaultAsync(
                predicate: v => v.VacancyId == id,
                include: source => source
                    .Include(x => x.EmploymentType));

            var mappedVacancy = _mapper.Map<DAL.Entities.Vacancy.Vacancy, VacancyDTO>(vacancy);

            return mappedVacancy;
        }
    }
}
