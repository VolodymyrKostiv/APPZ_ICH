namespace ICH.BLL.DTOs.User
{
    public class UserVacancyStatusDTO
    {
        public int UserVacancyStatusId { get; set; }

        public string Title { get; set; }
        public ICollection<UserVacanciesDTO> Vacancies { get; set; }
    }
}
