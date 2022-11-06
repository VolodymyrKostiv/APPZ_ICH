namespace ICH.Server.ViewModels.User
{
    public class CVViewModel
    {
        public int CVId { get; set; }
        public string Path { get; set; }
        public virtual UserInfoViewModel UserInfo { get; set; }
    }
}
