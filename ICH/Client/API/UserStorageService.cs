using Blazored.LocalStorage;
using ICH.Shared.ViewModels.User;

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
    }
}
