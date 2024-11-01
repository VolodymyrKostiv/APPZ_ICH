﻿using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
using ICH.Shared.ViewModels.Vacancy;
using Microsoft.AspNetCore.Mvc;

namespace ICH.Server.Controllers
{
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

        [HttpGet("Categories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _vacancyService.GetCategoriesAsync();

            var mappedCategories = _mapper.Map<IEnumerable<CategoryViewModel>>(categories);

            return Ok(mappedCategories);
        }

        [HttpGet("SpecialCategories")]
        public async Task<IActionResult> GetSpecialCategories()
        {
            var categories = await _vacancyService.GetSpecialCategoriesAsync();

            var mappedCategories = _mapper.Map<IEnumerable<SpecialCategoryViewModel>>(categories);

            return Ok(mappedCategories);
        }

        [HttpGet("WorkTypes")]
        public async Task<IActionResult> GetWorkTypes()
        {
            var workTypes = await _vacancyService.GetWorkTypesAsync();

            var mappedWorkTypes = _mapper.Map<IEnumerable<WorkTypeViewModel>>(workTypes);

            return Ok(mappedWorkTypes);
        }

        [HttpGet("EmploymentTypes")]
        public async Task<IActionResult> GetEmploymentTypes()
        {
            var employmentTypes = await _vacancyService.GetEmploymentTypesAsync();

            var mappedEmploymentTypes = _mapper.Map<IEnumerable<EmploymentTypeViewModel>>(employmentTypes);

            return Ok(mappedEmploymentTypes);
        }

        [HttpGet("Locations")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _vacancyService.GetLocationsAsync();

            var mappedLocations = _mapper.Map<IEnumerable<LocationViewModel>>(locations);

            return Ok(mappedLocations);
        }

        [HttpGet("VacancyStatuses")]
        public async Task<IActionResult> GetVacancyStatuses()
        {
            var statuses = await _vacancyService.GetVacancyStatusesAsync();

            var mappedStatuses = _mapper.Map<IEnumerable<VacancyStatusViewModel>>(statuses);

            return Ok(mappedStatuses);
        }

        //[HttpPost("AddVacancy")]
        //public async Task<IActionResult> AddVacancy([FromBody] VacancyViewModel vacancy)
        //{
        //    var mappedVacancy = _mapper.Map<VacancyDTO>(vacancy);

            

        //}

        /// <summary>
        /// Get all vacancies
        /// </summary>
        /// <returns>List of vacancies</returns>
        /// <response code="200">Successful operation</response>
        [HttpGet("AllVacancies")]
        public async Task<IActionResult> GetAllVacancies()
        {
            var vacancies = await _vacancyService.GetAllVacanciesAsync();

            var mappedVacancies = _mapper.Map<IEnumerable<VacancyDTO>, IEnumerable<VacancyViewModel>>(vacancies);

            return Ok(mappedVacancies);
        }

        /// <summary>
        /// Get filtered vacancies
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        [HttpPost("FilteredVacancies")]
        public async Task<IActionResult> GetFilteredVacancies([FromBody] VacancySearchFiltersViewModel fiters)
        {
            var mappedFilters = _mapper.Map<VacancySearchFiltersDTO>(fiters);

            var vacancies = await _vacancyService.GetFilteredVacanciesAsync(mappedFilters);

            var mappedVacancies = _mapper.Map<IEnumerable<VacancyViewModel>>(vacancies);

            return Ok(mappedVacancies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVacancyById(int id)
        {
            var vacancies = await _vacancyService.GetVacancyByIdAsync(id);

            var mappedVacancies = _mapper.Map<VacancyViewModel>(vacancies);

            return Ok(mappedVacancies);
        }
    }
}
