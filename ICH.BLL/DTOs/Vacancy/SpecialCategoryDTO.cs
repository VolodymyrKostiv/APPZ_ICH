﻿namespace ICH.BLL.DTOs.Vacancy
{
    public class SpecialCategoryDTO
    {
        public int SpecialCategoryId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyDTO> Vacancies { get; set; }
    }
}