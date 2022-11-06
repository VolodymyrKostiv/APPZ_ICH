namespace ICH.Server.ViewModels.User
{
    public class UserTypeViewModel
    {
        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<UserViewModel> Users { get; set; }
    }
}
