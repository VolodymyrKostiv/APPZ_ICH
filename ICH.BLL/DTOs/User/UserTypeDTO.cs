namespace ICH.BLL.DTOs.User
{
    public class UserTypeDTO
    {
        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<UserDTO> Users { get; set; }
    }
}
