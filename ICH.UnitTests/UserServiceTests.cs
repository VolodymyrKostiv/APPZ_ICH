using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.User;
using ICH.BLL.Services.User;
using ICH.DAL.Entities.User;
using ICH.DAL.Repositories.Interfaces.Base;
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

        public UserServiceTests()
        {
            _mapperMock = new Mock<IMapper>();
            _repoWrapperMock = new Mock<IRepositoryWrapper>();

            _userService = new UserService(_repoWrapperMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ReturnsFilledList()
        {
            //Arrange
            IEnumerable<User> users = _users;
            IEnumerable<UserDTO> userDTOs = _userDTOs;

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
            Assert.IsTrue(Enumerable.SequenceEqual<UserDTO>(userDTOs, result));
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ReturnsEmptyList()
        {
            //Arrange
            IEnumerable<User> users = Enumerable.Empty<User>();
            IEnumerable<UserDTO> userDTOs = Enumerable.Empty<UserDTO>();

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
        }

        [DataRow(1)]
        [TestMethod]
        public async Task GetUserByIdAsync_Found(int id)
        {
            //Arrange
            User user = _user;
            UserDTO userDTO = _userDTO;

            _repoWrapperMock
                .Setup(r => r.UserRepository.GetFirstOrDefaultAsync(It.IsAny<Expression<Func<User, bool>>>(),
                It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                .ReturnsAsync(user);
            _mapperMock.Setup(m => m.Map<User,
                UserDTO>(It.IsAny<User>()))
                .Returns(userDTO);

            //Act
            var result = await _userService.GetUserByIdAsync(id);

            //Assert
            Assert.IsInstanceOfType(result, typeof(UserDTO));
            Assert.IsNotNull(result);
            Assert.AreEqual(userDTO, result);
        }

        [DataRow(0)]
        [DataRow(-5)]
        [TestMethod]
        public async Task GetUserByIdAsync_NotFound(int id)
        {
            //Arrange
            User user = _user;
            UserDTO userDTO = _userDTO;

            _repoWrapperMock
                .Setup(r => r.UserRepository.GetFirstOrDefaultAsync(It.IsAny<Expression<Func<User, bool>>>(),
                It.IsAny<Func<IQueryable<User>, IIncludableQueryable<User, object>>>()))
                .ReturnsAsync(user);
            _mapperMock.Setup(m => m.Map<User,
                UserDTO>(It.IsAny<User>()))
                .Returns(userDTO);

            //Act
            var result = await _userService.GetUserByIdAsync(id);

            //Assert
            Assert.IsInstanceOfType(result, typeof(UserDTO));
            Assert.IsNull(result);
        }

        private readonly User _user = new User
        {
            Login = "Chel",
            Password = "***",
            UserId = 1,
        };

        private readonly UserDTO _userDTO = new UserDTO
        {
            Login = "Chel",
            Password = "***",
            UserId = 1,
        };

        private readonly IEnumerable<User> _users = new List<User>
        {
            new User
            {
                Login = "Chel1",
                Password = "***",
                UserId = 1,
            },
            new User
            {
                Login = "Chel2",
                Password = "***",
                UserId = 2,
            },
            new User
            {
                Login = "Chel3",
                Password = "***",
                UserId = 3,
            },
        };

        private readonly IEnumerable<UserDTO> _userDTOs = new List<UserDTO>
        {
            new UserDTO
            {
                Login = "Chel1",
                Password = "***",
                UserId = 1,
            },
            new UserDTO
            {
                Login = "Chel2",
                Password = "***",
                UserId = 2,
            },
            new UserDTO
            {
                Login = "Chel3",
                Password = "***",
                UserId = 3,
            },
        };
    }
}