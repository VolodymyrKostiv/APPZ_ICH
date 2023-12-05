namespace ICH.Shared.ViewModels.Vacancy
{
    public class VacancyStatusViewModel
    {
        public int VacancyStatusId { get; set; }
        public string Title { get; set; }

        public ICollection<VacancyViewModel> Vacancies { get; set; }
    }
}
