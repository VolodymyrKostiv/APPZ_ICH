using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Shared.ViewModels.User
{
    public class UserInfoViewModel
    {
        public int UserInfoId { get; set; }
        public string? Description { get; set; }
        public LocationViewModel? Location { get; set; }
        public ICollection<UserViewModel> Users { get; set; }
    }
}
