using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace ICH.BLL.Services.User
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private const int ValidTRPDaysFromCreation = 365;

        public UserService(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _repoWrapper.UserRepository.GetAllAsync(
                include: source => source
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.WorkType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Category)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.EmploymentType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Location)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.SpecialCategories));

            var mappedUsers = _mapper.Map<IEnumerable<UserDTO>>(users);

            return mappedUsers;
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.WorkType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Category)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.EmploymentType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Location)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.SpecialCategories),
                predicate: p => p.UserId == id);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }

        public async Task<UserDTO> GetUserByUserType(UserTypeDTO type)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.WorkType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Category)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.EmploymentType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Location)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.SpecialCategories),
                predicate: p => p.UserType.UserTypeId == type.UserTypeId);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }

        public async Task<IEnumerable<UserDTO>> GetAllTRPs()
        {
            IEnumerable<UserDTO> map = null;
            try
            {

                var users = await _repoWrapper.UserRepository.GetAllAsync(
                    include: source => source
                    .Include(x => x.UserInfo)
                        .ThenInclude(y => y.WorkType)
                    .Include(x => x.UserInfo)
                        .ThenInclude(y => y.Category)
                    .Include(x => x.UserInfo)
                        .ThenInclude(y => y.EmploymentType)
                    .Include(x => x.UserInfo)
                        .ThenInclude(y => y.Location)
                    .Include(x => x.UserInfo)
                        .ThenInclude(y => y.SpecialCategories),
                    predicate: x => x.UserType.Title == "TRP");

                map = _mapper.Map<IEnumerable<UserDTO>>(users);
            }
            catch (Exception ex)
            {

            }

            return map;
        }

        public async Task<IEnumerable<UserDTO>> GetFilteredTRPs(UserSearchFiltersDTO filters)
        {
            var vacancies = await _repoWrapper.UserRepository.GetAllAsync(
             include: source => source
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.WorkType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Category)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.EmploymentType)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.Location)
                .Include(x => x.UserInfo)
                    .ThenInclude(y => y.SpecialCategories),
             predicate: x => x.UserType.Title == "TRP");

            if (filters != null)
            {
                if (filters.SearchName != null && filters.SearchName != "")
                {
                    vacancies = vacancies.Where(x => x.UserInfo?.Position != null && x.UserInfo.Position.ToLowerInvariant().Contains(filters.SearchName.ToLowerInvariant()))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedLocation != null)
                {
                    vacancies = vacancies.Where(x => x.UserInfo?.Location != null && x.UserInfo?.Location.LocationId == filters.SelectedLocation.LocationId)?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedEmploymentTypes != null && filters.SelectedEmploymentTypes.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedEmploymentTypes.Any(x => y.UserInfo?.EmploymentType != null && x.EmploymentTypeId == y.UserInfo.EmploymentType.EmploymentTypeId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedCategories != null && filters.SelectedCategories.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedCategories.Any(x => y.UserInfo?.Category != null && x.CategoryId == y.UserInfo.Category.CategoryId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedWorkTypes != null && filters.SelectedWorkTypes.Count() != 0)
                {
                    vacancies = vacancies.Where(y => filters.SelectedWorkTypes.Any(x => y.UserInfo?.WorkType != null && x.WorkTypeId == y.UserInfo.WorkType.WorkTypeId))?.ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }

                if (filters.SelectedSpecialCategories != null && filters.SelectedSpecialCategories.Count() != 0)
                {
                    vacancies = vacancies.Where(y => y.UserInfo?.SpecialCategories != null && y.UserInfo.SpecialCategories.Any(x =>
                    filters.SelectedSpecialCategories.Any(z => z.SpecialCategoryId == x.SpecialCategoryId))).ToList();
                    if (vacancies == null)
                    {
                        return null;
                    }
                }
            }

            var currentTime = DateTime.Now;
            vacancies = vacancies.Where(x => currentTime.Subtract((DateTime)x.UserInfo?.CreationTime).TotalDays < ValidTRPDaysFromCreation);

            var mappedVacancies = _mapper.Map<IEnumerable<UserDTO>>(vacancies);

            return mappedVacancies;
        }
    }
}
