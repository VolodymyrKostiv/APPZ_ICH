namespace ICH.BLL.DTOs.User
{
    public class UserVacanciesDTO
    {
        public int UserVacanaId { get; set; }

        public int? UserId { get; set; }
        public UserDTO? User { get; set; }

        public int? VacancyId { get; set; }
        public Vacancy.VacancyDTO? Vacancy { get; set; }

        public UserVacancyStatusDTO UserVacancyStatus { get; set; }
    }
}
