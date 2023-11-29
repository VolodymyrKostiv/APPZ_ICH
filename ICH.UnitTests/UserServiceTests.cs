using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.User;
using ICH.BLL.Services.User;
using ICH.DAL;
using ICH.DAL.Entities.User;
using ICH.DAL.Repositories.Interfaces.Base;
using ICH.DAL.Repositories.Realizations.User;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System.Linq.Expressions;

namespace ICH.UnitTests
{
    [TestClass]
    public class UserServiceTests
    {
        private readonly IUserService _userService;
        private readonly Mock<IRepositoryWrapper> _repoWrapperMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ICHDBContext> _dbContextMock;

        public UserServiceTests()
        {
            _mapperMock = new Mock<IMapper>();
            _repoWrapperMock = new Mock<IRepositoryWrapper>();
            _dbContextMock = new Mock<ICHDBContext>();

            _userService = new UserService(_repoWrapperMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ReturnsFilledList()
        {
            //Arrange
            var users = _users;
            var userDTOs = _userDTOs;
            var userService = _userService;
            var userRepository = new UserRepository(_dbContextMock.Object);

            _repoWrapperMock.Setup(repo => repo.UserRepository.GetAllAsync(
            It.IsAny<Expression<Func<User, bool>>>(),
            It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
            .ReturnsAsync(users);

            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<UserDTO>>(users))
                .Returns(userDTOs);

            // Act
            var result = await userService.GetAllUsersAsync();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<UserDTO>));
            Assert.AreEqual(userDTOs.Count(), result.Count());

            _repoWrapperMock.Verify(repo => repo.UserRepository.GetAllAsync(
            It.IsAny<Expression<Func<User, bool>>>(),
            It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()),
            Times.Once);

            _mapperMock.Verify(mapper => mapper.Map<IEnumerable<UserDTO>>(users), Times.Once);
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ReturnsEmptyList()
        {
            //Arrange
            var users = Enumerable.Empty<User>();
            var userDTOs = Enumerable.Empty<UserDTO>();

            _repoWrapperMock
                .Setup(r => r.UserRepository.GetAllAsync(It.IsAny<Expression<Func<User, bool>>>(),
                It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                .ReturnsAsync(users);
            _mapperMock.Setup(m => m.Map<IEnumerable<User>,
                IEnumerable<UserDTO>>(It.IsAny<IEnumerable<User>>()))
                .Returns(userDTOs);

            //Act
            var result = await _userService.GetAllUsersAsync();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<UserDTO>));
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());

            _repoWrapperMock.Verify(repo => repo.UserRepository.GetAllAsync(It.IsAny<Expression<Func<User, bool>>>(),
              It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()),
              Times.Once);

            _mapperMock.Verify(mapper => mapper.Map<IEnumerable<UserDTO>>(users), Times.Once);
        }

        [DataRow(1)]
        [DataRow(3)]
        [DataRow(11111)]
        [TestMethod]
        public async Task GetUserByIdAsync_Found(int id)
        {
            //Arrange
            var user = _user;
            var userDTO = _userDTO;

            _repoWrapperMock
                .Setup(repo => repo.UserRepository.GetFirstOrDefaultAsync(
                    It.IsAny<Expression<Func<User, bool>>>(),
                    It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                .ReturnsAsync(user);

            _mapperMock
                .Setup(mapper => mapper.Map<UserDTO>(user))
                .Returns(userDTO);

            //Act
            var result = await _userService.GetUserByIdAsync(id);

            //Assert
            Assert.IsInstanceOfType(result, typeof(UserDTO));
            Assert.IsNotNull(result);
            Assert.AreEqual(userDTO, result);

            _mapperMock.Verify(mapper => mapper.Map<UserDTO>(user), Times.Once);
        }

        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-1111111)]
        [TestMethod]
        public async Task GetUserByIdAsync_NotFound(int id)
        {
            //Arrange
            User user = _user;
            UserDTO userDTO = _userDTO;

            _repoWrapperMock
                     .Setup(repo => repo.UserRepository.GetFirstOrDefaultAsync(
                         It.IsAny<Expression<Func<User, bool>>>(),
                         It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                     .ReturnsAsync((User)null);

            _mapperMock
                .Setup(mapper => mapper.Map<UserDTO>(user))
                .Returns((UserDTO)null);

            //Act
            var result = await _userService.GetUserByIdAsync(id);

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetUserByUserType_ReturnsUserDTO()
        {
            // Arrange
            var userTypeDto = new UserTypeDTO
            {
                UserTypeId = 1,
                // Initialize other properties
            };
            var userEntity = _user;
            var userDto = _userDTO;
            userDto.UserType = _userType1DTO;
            userEntity.UserType = _userType1;

            _repoWrapperMock
                .Setup(repo => repo.UserRepository.GetFirstOrDefaultAsync(
                    It.IsAny<Expression<Func<User, bool>>>(),
                    It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                .ReturnsAsync(userEntity);

            _mapperMock
                .Setup(mapper => mapper.Map<UserDTO>(userEntity))
                .Returns(userDto);

            // Act
            var result = await _userService.GetUserByUserType(userTypeDto);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UserDTO));
            Assert.AreEqual(result.UserType, _userType1DTO);
        }

        private readonly UserTypeDTO _userType1DTO =  new UserTypeDTO { UserTypeId = 1, Title = "Test1" };
        private readonly UserType _userType1 = new UserType { UserTypeId = 1, Title = "Test1" };

        private readonly User _user = new User { Login = "1", Password = "***", UserId = 1, };

        private readonly UserDTO _userDTO = new UserDTO { Login = "1", Password = "***", UserId = 1, };

        private readonly IEnumerable<User> _users = new List<User>
        {
            new User { Login = "1", Password = "***", UserId = 1, },
            new User { Login = "2", Password = "***", UserId = 2, },
            new User { Login = "3", Password = "***", UserId = 3, },
        };

        private readonly IEnumerable<UserDTO> _userDTOs = new List<UserDTO>
        {
            new UserDTO { Login = "1", Password = "***", UserId = 1, },
            new UserDTO { Login = "2", Password = "***", UserId = 2, },
            new UserDTO { Login = "3", Password = "***", UserId = 3, },
        };
    }
}