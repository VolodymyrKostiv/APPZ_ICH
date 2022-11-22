namespace ICH.BLL.DTOs.Vacancy
{
    public class WorkTypeDTO
    {
        public int WorkTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyDTO> Vacancies { get; set; }
    }
}
