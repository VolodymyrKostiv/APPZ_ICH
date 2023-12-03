using ICH.Shared.ViewModels.User;
using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Client.API
{
    public class UserService : ApiService
    {
        public async Task<IEnumerable<UserViewModel>> GetAllUsers()
        {
            var items = await GetItems<IEnumerable<UserViewModel>>(TRPGlobals.AllTRPsUri);

            return items;
        }

        public async Task<IEnumerable<UserViewModel>> GetFilteredUsers(UserSearchFiltersViewModel filters)
        {
            var items = await GetItemsViaPost<IEnumerable<UserViewModel>>(TRPGlobals.FilteredTRPsUri, filters);

            return items;
        }

        public async Task<UserViewModel> LoginUser(UserLoginCredentialsViewModel creds)
        {
            var item = await GetItemsViaPost<UserViewModel>(TRPGlobals.LoginUserUri, creds);

            return item;
        }
    }
}
