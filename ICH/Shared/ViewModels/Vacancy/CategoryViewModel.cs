namespace ICH.Shared.ViewModels.Vacancy
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyViewModel> Vacancies { get; set; }
    }
}
