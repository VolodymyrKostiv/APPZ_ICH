using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.Interfaces.User;
using ICH.Shared.ViewModels.User;
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

        /// <summary>
        /// Get all vacancies
        /// </summary>
        /// <returns>List of trps</returns>
        /// <response code="200">Successful operation</response>
        [HttpGet("AllTRPs")]
        public async Task<IActionResult> GetAllTRPs()
        {
            var vacancies = await _userService.GetAllTRPs();

            var mappedVacancies = _mapper.Map<IEnumerable<UserDTO>, IEnumerable<UserViewModel>>(vacancies);

            return Ok(mappedVacancies);
        }

        [HttpGet("UserVacancyStatuses")]
        public async Task<IActionResult> GetAllUserVacancyStatuses()
        {
            var userVacancyStatuses = await _userService.GetUserVacancyStatusesAsync();

            var mappedVacancies = _mapper.Map<IEnumerable<UserVacanciesViewModel>>(userVacancyStatuses);

            return Ok(mappedVacancies);
        }


        /// <summary>
        /// Get filtered vacancies
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        [HttpPost("FilteredTRPs")]
        public async Task<IActionResult> GetFilteredVacancies([FromBody] UserSearchFiltersViewModel fiters)
        {
            var mappedFilters = _mapper.Map<UserSearchFiltersDTO>(fiters);

            var users = await _userService.GetFilteredTRPs(mappedFilters);

            var mappedUsers = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Ok(mappedUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            var mappedUser = _mapper.Map<UserViewModel>(user);

            return Ok(mappedUser);
        }

        [HttpPost("LoginUser")]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginCredentialsViewModel creds)
        {
            var mappedCreds = _mapper.Map<UserLoginCredentialsDTO>(creds);

            var user = await _userService.GetUserByCredsAsync(mappedCreds);

            if (user == null)
            {
                return NotFound();
            }

            var mappedUsers = _mapper.Map<UserViewModel>(user);

            return Ok(mappedUsers);
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserViewModel user)
        {
            if (user == null)
            {
                return BadRequest("Invalid model");
            }

            try
            {
                var mappedUser = _mapper.Map<UserDTO>(user);

                await _userService.UpdateUserAsync(mappedUser);

                return Ok("Resource updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }


    }
}
