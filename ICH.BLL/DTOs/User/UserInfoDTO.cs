using ICH.DAL.Entities.General;

namespace ICH.BLL.DTOs.User
{
    public class UserInfoDTO
    {
        public int UserInfoId { get; set; }
        public string? Description { get; set; }
        public Location? Location { get; set; }
        public ICollection<UserDTO> Users { get; set; }
    }
}
