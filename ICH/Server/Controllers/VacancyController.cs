using AutoMapper;
using ICH.BLL.Interfaces.Vacancy;
using Microsoft.AspNetCore.Mvc;

namespace ICH.Server.Controllers
{
    /// <summary>
    /// Implements all business logic related to vacancies.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVacancyService _vacancyService;

        public VacancyController(IMapper mapper, IVacancyService vacancyService)
        {
            _mapper = mapper;
            _vacancyService = vacancyService;
        }

        /// <summary>
        /// Get all vacancies
        /// </summary>
        /// <returns>List of vacancies</returns>
        /// <response code="200">Successful operation</response>
        [HttpGet("Vacancies")]
        public async Task<IActionResult> GetAllVacancies()
        {
            var vacancies = await _vacancyService.GetAllVacanciesAsync();

            return Ok(vacancies);
        }


        ///// <summary>
        ///// Get filtered vacancies
        ///// </summary>
        ///// <returns></returns>
        ///// <response code="200">Successful operation</response>
        //[HttpGet("FilteredVacancies")]
        //public async Task<IActionResult> GetFilteredVacancies()
        //{

        //}
    }
}
