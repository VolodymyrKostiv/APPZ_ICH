using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
using ICH.CommonModels.Filters.Vacancy;
using ICH.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            var categories = await _repoWrapper.CategoryRepository.GetAllAsync();

            var mappedCategories = _mapper.Map<IEnumerable<CategoryDTO>>(categories);

            return mappedCategories;
        }

        public async Task<IEnumerable<EmploymentTypeDTO>> GetEmploymentTypesAsync()
        {
            var employmentTypes = await _repoWrapper.EmploymentTypeRepository.GetAllAsync();

            var mappedEmploymentTypes = _mapper.Map<IEnumerable<EmploymentTypeDTO>>(employmentTypes);

            return mappedEmploymentTypes;
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

        public async Task<IEnumerable<LocationDTO>> GetLocationsAsync()
        {
            var locations = await _repoWrapper.LocationRepository.GetAllAsync();

            var mappedLocations = _mapper.Map<IEnumerable<LocationDTO>>(locations);

            return mappedLocations;
        }

        public async Task<IEnumerable<SpecialCategoryDTO>> GetSpecialCategoriesAsync()
        {
            var specialCategories = await _repoWrapper.SpecialCategoryRepository.GetAllAsync();

            var mappedSpecialCategories = _mapper.Map<IEnumerable<SpecialCategoryDTO>>(specialCategories);

            return mappedSpecialCategories;
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

        public async Task<IEnumerable<WorkTypeDTO>> GetWorkTypesAsync()
        {
            var workTypes = await _repoWrapper.WorkTypeRepository.GetAllAsync();

            var mappedWorkTypes = _mapper.Map<IEnumerable<WorkTypeDTO>>(workTypes);

            return mappedWorkTypes;
        }
    }
}
