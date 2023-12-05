
namespace ICH.Shared.ViewModels.User
{
    public class UserTypeViewModel
    {
        public int UserTypeId { get; set; }
        public string Title { get; set; }
        //public ICollection<UserViewModel> Users { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserTypeViewModel model &&
                   UserTypeId == model.UserTypeId &&
                   Title == model.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserTypeId, Title);
        }
    }
}
