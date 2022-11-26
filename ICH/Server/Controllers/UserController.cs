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

        ///// <summary>
        ///// Get filtered vacancies
        ///// </summary>
        ///// <returns></returns>
        ///// <response code="200">Successful operation</response>
        [HttpPost("FilteredTRPs")]
        public async Task<IActionResult> GetFilteredVacancies([FromBody] UserSearchFiltersViewModel fiters)
        {
            var mappedFilters = _mapper.Map<UserSearchFiltersDTO>(fiters);

            var vacancies = await _userService.GetFilteredTRPs(mappedFilters);

            var mappedVacancies = _mapper.Map<IEnumerable<UserViewModel>>(vacancies);

            return Ok(mappedVacancies);
        }
    }
}
