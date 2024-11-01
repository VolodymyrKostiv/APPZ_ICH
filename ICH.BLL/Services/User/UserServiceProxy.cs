﻿using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.Logger;
using ICH.BLL.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Base;

namespace ICH.BLL.Services.User
{
    public class UserServiceProxy : IUserService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ILoggerManager _logger;

        public UserServiceProxy(IRepositoryWrapper repoWrapper, IMapper mapper, IUserService userService, ILoggerManager logger)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
            _userService = userService;
            _logger = logger;
        }

        public Task<IEnumerable<UserDTO>> GetAllTRPs()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            _logger.LogInfo($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
            var res = await _userService.GetAllUsersAsync();
            return res;
        }

        public Task<IEnumerable<UserDTO>> GetFilteredTRPs(UserSearchFiltersDTO filters)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserByCredsAsync(UserLoginCredentialsDTO creds)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            _logger.LogInfo($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
            var res = await _userService.GetUserByIdAsync(id);
            return res;
        }

        public Task<UserDTO> GetUserByUserType(UserTypeDTO type)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserVacancyStatusDTO>> GetUserVacancyStatusesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
