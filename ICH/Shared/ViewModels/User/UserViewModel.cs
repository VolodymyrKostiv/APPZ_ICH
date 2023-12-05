namespace ICH.Shared.ViewModels.User
{
    public class UserViewModel : ICloneable
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserTypeViewModel? UserType { get; set; }
        public UserInfoViewModel? UserInfo { get; set; }
        //public ICollection<VacancyViewModel> Vacancies { get; set; }

        public object Clone()
        {
            return new UserViewModel
            {
                UserId = this.UserId,
                Login = this.Login,
                Password = this.Password,
                UserType = this.UserType,
                UserInfo = this.UserInfo,
                //Vacancies = this.Vacancies
            };
        }

        public override bool Equals(object? obj)
        {
            return obj is UserViewModel model &&
                   UserId == model.UserId &&
                   Login == model.Login &&
                   Password == model.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserId, Login, Password);
        }
    }
}
