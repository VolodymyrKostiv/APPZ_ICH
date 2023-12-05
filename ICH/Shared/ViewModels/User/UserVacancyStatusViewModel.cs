namespace ICH.Shared.ViewModels.User
{
    public class UserVacancyStatusViewModel
    {
        public int UserVacancyStatusId { get; set; }

        public string Title { get; set; }
        public ICollection<UserVacanciesViewModel> Vacancies { get; set; }
    }
}
