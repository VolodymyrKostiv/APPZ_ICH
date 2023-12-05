using Blazored.LocalStorage;
using ICH.Client.Enums;
using ICH.Client.Pages.CreatePages;
using ICH.Shared.ViewModels.User;
using ICH.Shared.ViewModels.Vacancy;
using System.Linq;

namespace ICH.Client.API
{
    public class UserStorageService : StorageService
    {
        public UserStorageService(ILocalStorageService storage) : base(storage)
        {

        }

        public async Task LoginUser(UserViewModel user)
        {
            await AddItem(Constants.Constants.LocalStorageUser, user);
        }

        public async Task ExitUser()
        {
            await RemoveItem(Constants.Constants.LocalStorageUser);
        }

        public async Task<bool> IsUserLoginned()
        {
            var exists = await ItemExists(Constants.Constants.LocalStorageUser);

            return exists;
        }

        public async Task<UserViewModel> GetLoginnedUser()
        {
            var user = await GetItem<UserViewModel>(Constants.Constants.LocalStorageUser);

            return user;
        }

        public async Task UpdateCurrentUserInfo(UserViewModel user)
        {
            await UpdateItem(Constants.Constants.LocalStorageUser, user);
        }

        public async Task AddVacancy(VacancyViewModel vacancy)
        {
            await AddItem<VacancyViewModel>(Constants.Constants.AddedVacancy, vacancy);
        }

        public async Task<VacancyViewModel> GetAddedVacancy()
        {
            return await GetItem<VacancyViewModel>(Constants.Constants.AddedVacancy);
        }

        public async Task UserApplyOnVacancy(UserViewModel user, VacancyViewModel vacancy)
        {
            UserVacanciesViewModel userVacanciesViewModel = new UserVacanciesViewModel()
            {
                User = user,
                UserId = user.UserId,
                Vacancy = vacancy,
                VacancyId = vacancy.VacancyId,
                UserVacancyStatus = new UserVacancyStatusViewModel()
                { Title = UserVacancyStatus.Applied.ToString(), UserVacancyStatusId = ((int)UserVacancyStatus.Applied), },
            };

            var appliedVacancies = await GetItem<IEnumerable<UserVacanciesViewModel>>(Constants.Constants.LocalStorageUserAppliedVacancies);

            if (appliedVacancies != null)
            {
                appliedVacancies.ToList().Add(userVacanciesViewModel);
            }
            else
            {
                appliedVacancies = new List<UserVacanciesViewModel>() { userVacanciesViewModel };
            }

            await AddItem<IEnumerable<UserVacanciesViewModel>>(Constants.Constants.LocalStorageUserAppliedVacancies, appliedVacancies);
        }

        public async Task ChangeUserVacancyStatus(UserViewModel user, VacancyViewModel vacancy, UserVacancyStatus status)
        {
            var appliedVacancies = await GetItem<IEnumerable<UserVacanciesViewModel>>(Constants.Constants.LocalStorageUserAppliedVacancies);
            var appliedVacanciesList = appliedVacancies.ToList();

            var vacancyToChange = appliedVacanciesList.FirstOrDefault(x => x.UserId == user.UserId && x.VacancyId == vacancy.VacancyId);

            if (vacancyToChange != null)
            {
                appliedVacanciesList.Remove(vacancyToChange);

                vacancyToChange.UserVacancyStatus = new UserVacancyStatusViewModel()
                {
                    Title = status.ToString(),
                    UserVacancyStatusId = ((int)status),
                };

                appliedVacanciesList.Add(vacancyToChange);

                await AddItem<IEnumerable<UserVacanciesViewModel>>(Constants.Constants.LocalStorageUserAppliedVacancies, appliedVacanciesList);
            }
        }

        public async Task<UserVacancyStatus> GetUserVacancyStatus(UserViewModel user, VacancyViewModel vacancy)
        {
            var appliedVacancies = await GetItem<IEnumerable<UserVacanciesViewModel>>(Constants.Constants.LocalStorageUserAppliedVacancies);
            var appliedVacanciesList = appliedVacancies?.ToList();
            var searchedVacancy = appliedVacanciesList?.FirstOrDefault(x => x.UserId == user.UserId && x.VacancyId == vacancy.VacancyId);

            if (searchedVacancy != null)
            {
                return (UserVacancyStatus)searchedVacancy.UserVacancyStatus.UserVacancyStatusId;
            }
            return UserVacancyStatus.None;
        }
    }
}
