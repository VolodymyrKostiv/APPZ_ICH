namespace ICH.Shared.ViewModels.Vacancy
{
    public class WorkTypeViewModel
    {
        public int WorkTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyViewModel> Vacancies { get; set; }
    }
}
