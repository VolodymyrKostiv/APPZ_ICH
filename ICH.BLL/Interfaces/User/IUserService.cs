using ICH.BLL.DTOs.User;

namespace ICH.BLL.Interfaces.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
    }
}
