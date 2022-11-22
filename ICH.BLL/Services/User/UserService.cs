using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace ICH.BLL.Services.User
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public UserService(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _repoWrapper.UserRepository.GetAllAsync(
                include: source => source.Include(x => x.UserInfo));

            var mappedUsers = _mapper.Map<IEnumerable<UserDTO>>(users);

            return mappedUsers;
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source.Include(x => x.UserInfo),
                predicate: p => p.UserId == id);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }

        public async Task<UserDTO> GetUserByUserType(UserTypeDTO type)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source.Include(x => x.UserInfo),
                predicate: p => p.UserType.UserTypeId == type.UserTypeId);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }
    }
}
