﻿namespace ICH.BLL.DTOs.Vacancy
{
    public class EmploymentTypeDTO
    {
        public int EmploymentTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyDTO> Vacancies { get; set; }
    }
}