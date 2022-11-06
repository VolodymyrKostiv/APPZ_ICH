using ICH.Server.ViewModels.Vacancy;

namespace ICH.Server.ViewModels.User
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserTypeViewModel UserType { get; set; }
        public virtual UserInfoViewModel UserInfo { get; set; }
        public ICollection<VacancyViewModel> Vacancies { get; set; }
    }
}
