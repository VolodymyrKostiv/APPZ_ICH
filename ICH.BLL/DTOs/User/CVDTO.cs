namespace ICH.BLL.DTOs.User
{
    public class CVDTO
    {
        public int CVId { get; set; }
        public string Path { get; set; }
        public virtual UserInfoDTO UserInfo { get; set; }
    }
}
