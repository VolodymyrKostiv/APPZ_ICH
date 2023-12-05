namespace ICH.BLL.DTOs.Vacancy
{
    public class VacancyStatusDTO
    {
        public int VacancyStatusId { get; set; }
        public string Title { get; set; }

        public ICollection<VacancyDTO> Vacancies { get; set; }
    }
}
