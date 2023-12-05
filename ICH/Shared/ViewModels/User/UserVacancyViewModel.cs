namespace ICH.Shared.ViewModels.User
{
    public class UserVacanciesViewModel
    {
        public int UserVacanaId { get; set; }

        public int? UserId { get; set; }
        public UserViewModel? User { get; set; }

        public int? VacancyId { get; set; }
        public Vacancy.VacancyViewModel? Vacancy { get; set; }

        public UserVacancyStatusViewModel UserVacancyStatus { get; set; }
    }
}
