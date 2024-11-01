﻿using ICH.BLL.DTOs.User;

namespace ICH.BLL.Interfaces.User
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByUserType(UserTypeDTO type);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<IEnumerable<UserDTO>> GetFilteredTRPs(UserSearchFiltersDTO filters);
        Task<IEnumerable<UserDTO>> GetAllTRPs();
        Task<IEnumerable<UserVacancyStatusDTO>> GetUserVacancyStatusesAsync();
        Task<UserDTO> GetUserByCredsAsync(UserLoginCredentialsDTO creds);
        Task UpdateUserAsync(UserDTO user);
    }
}
