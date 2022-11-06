namespace ICH.BLL.DTOs.User
{
    public class UserInfoDTO
    {
        public int UserInfoId { get; set; }
        public string JobTitle { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual CVDTO CV { get; set; }
    }
}
