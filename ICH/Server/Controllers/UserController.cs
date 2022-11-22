using AutoMapper;
using ICH.BLL.Interfaces.User;
using ICH.BLL.Interfaces.Vacancy;
using ICH.BLL.Services.User;
using ICH.BLL.Services.Vacancy;
using ICH.Shared.ViewModels.User;
using ICH.Shared.ViewModels.Vacancy;
using Microsoft.AspNetCore.Mvc;

namespace ICH.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet("Users")]
        public async Task<IActionResult> GetCategories()
        {
            var users = await _userService.GetAllUsersAsync();

            var mappedUsers = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Ok(mappedUsers);
        }
    }
}
