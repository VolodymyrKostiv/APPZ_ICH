
namespace ICH.Shared.ViewModels.User
{
    public class UserLoginCredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserLoginCredentialsViewModel model &&
                   UserName == model.UserName &&
                   Password == model.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserName, Password);
        }
    }
}
