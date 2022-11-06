namespace ICH.Server.ViewModels.User
{
    public class UserInfoViewModel
    {
        public int UserInfoId { get; set; }
        public string JobTitle { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }

        public virtual UserViewModel User { get; set; }
        public virtual CVViewModel CV { get; set; }
    }
}
