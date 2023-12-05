using ICH.Shared.ViewModels.User;

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

        public async Task<UserViewModel> GetUserDetails(int id)
        {
            var item = await GetItems<UserViewModel>(TRPGlobals.CandidateUri + '/' + id);

            return item;
        }

        public async Task<bool> UpdateUserData(UserViewModel user)
        {
            var item = await UpdateItem<UserViewModel>(TRPGlobals.UpdateUserUri, user);

            return item;
        }
    }
}
