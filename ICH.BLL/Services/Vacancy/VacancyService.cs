using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
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
                    .Include(x => x.EmploymentType)
                    .Include(x => x.Category)
                    .Include(x => x.SpecialCategories)
                    .Include(x => x.Location)
                    .Include(x => x.WorkType));

            var mappedVacancies = _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);

            return mappedVacancies;
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

        public async Task<IEnumerable<VacancyDTO>> GetFilteredVacanciesAsync(VacancySearchFiltersDTO filters)
        {
            var vacancies = await _repoWrapper.VacancyRepository.GetAllAsync(
                 include: source => source
                     .Include(x => x.EmploymentType)
                     .Include(x => x.SpecialCategories)
                     .Include(x => x.Category)
                     .Include(x => x.Location)
                     .Include(x => x.WorkType));

            if (filters != null)
            {
                if (filters.SearchName != null && filters.SearchName != "")
                {
                    vacancies = vacancies.Where(x => x.Title != null && x.Title.ToLowerInvariant().Contains(filters.SearchName.ToLowerInvariant()))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedLocation != null)
                {
                    vacancies = vacancies.Where(x => x.Location != null && x.Location.LocationId == filters.SelectedLocation.LocationId)?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedEmploymentTypes != null && filters.SelectedEmploymentTypes.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedEmploymentTypes.Any(x => y.EmploymentType != null && x.EmploymentTypeId == y.EmploymentType.EmploymentTypeId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedCategories != null && filters.SelectedCategories.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedCategories.Any(x => y.Category != null && x.CategoryId == y.Category.CategoryId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedWorkTypes != null && filters.SelectedWorkTypes.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedWorkTypes.Any(x => y.WorkType != null && x.WorkTypeId == y.WorkType.WorkTypeId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedSpecialCategories != null)
                {
                    vacancies = vacancies.Where(y => y.SpecialCategories.Any(x =>
                    filters.SelectedSpecialCategories.Any(z => z.SpecialCategoryId == x.SpecialCategoryId))).ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }
            }

            var mappedVacancies = _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);

            return mappedVacancies;
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
                    .Include(x => x.EmploymentType)
                    .Include(x => x.Category)
                    .Include(x => x.SpecialCategories)
                    .Include(x => x.Location)
                    .Include(x => x.WorkType));

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
